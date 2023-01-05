const initialState = {
    items: [],
    isLoaded: false
}

const goodsReducer = (state = initialState, action) => {
    switch (action.type) {
        case 'SET_GOODS' :
            console.log("getall");
            return {
                ...state,
                items: action.payload,
                isLoaded: true,
            }
        case 'SET__LOADED' :
            return {
                ...state,
                isLoaded: action.payload,
            }
        default :
            return state
    }

}

export default goodsReducer