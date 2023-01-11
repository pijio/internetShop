import axios from "axios";
import baseUrl from "../../../apiEndpoint";

async function invoke (Data, setError, setSuccess, endpointPath) {
    await axios.post(baseUrl + endpointPath, Data)
        .then((response) => {
            const username = response.data.username;
            const authtoken = response.data.token;
            localStorage.setItem('username', username)
            localStorage.setItem('authtoken', authtoken)
            setSuccess(true)
        }).catch((error) => {
        if(error.response) {
            setError(error.response)
        } else {
            setError("Непредвиденная ошибка на стороне сервера")
        }
    });
}
export default invoke