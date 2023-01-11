import axios from "axios";
import baseUrl from "../../../apiEndpoint";

const invoke = (username, password, setError) => {
    const loginEndpoint = '/auth'
    axios.post(baseUrl + loginEndpoint, JSON.stringify({
        username: username,
        password: password
    })).then(
        (response) => {
            const username = response.data.username;
            const authtoken = response.data.token;
            localStorage.setItem('username', username)
            localStorage.setItem('authtoken', authtoken)
            return true
        }
    ).catch(
        (error) => {
            if(error.response) {
                setError(error.response.data.message)
            }
            else {
                setError("Непредвиденная ошибка на стороне сервера")
            }
            return false
        }
    )
}
export default invoke