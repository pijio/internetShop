import useAuth from "../../hooks/useAuth/useAuth";

const initialState = {
    username: localStorage.getItem('username') ?? '',
    isAuthed: false
}

const authReducer = (state = initialState, action) => {
    switch(action.type) {
        case 'SET_AUTH_FLAG': {
            return {
                ...state,
                isAuthed: action.payload
            }
        }
        case 'SET_USERNAME': {
            return {
                ...state,
                username: action.payload
            }
        }
        default:
            return state
    }
}

export default authReducer