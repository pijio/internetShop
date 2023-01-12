import useAuth from "../../hooks/useAuth/useAuth";

const initialState = {
    username: localStorage.getItem('username') ?? '',
    isAuthed: false
}

const authReducer = (action, state = initialState) => {
    switch(action.type) {
        case 'SET_AUTH_FLAG': {
            return {
                ...state,
                isAuthed: action.payload
            }
        }
        default:
            return state
    }
}

export default authReducer