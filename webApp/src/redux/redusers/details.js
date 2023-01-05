

const initialState = {
    detail :null
}




const detailsReducer = (state=initialState,action)=>{
    switch (action.type) {
        case 'SET__DETAILS' :
            return {
                ...state,
                detail: action.payload,
            }
        default : return state
    }

}



export default detailsReducer