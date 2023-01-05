const initialState = {
    items: {},
    totalPrice: 0,
    totalCount: 0
}


const cartReducer = (state = initialState, action) => {
    switch (action.type) {
        case 'ADD_GOODS_CART' : {
            const newItems = {
                ...state.items,
                [action.payload.id]: !state.items[action.payload.id]
                    ? [action.payload]
                    : [...state.items[action.payload.id], action.payload]
            }

            const allGoods = [].concat.apply([], Object.values(newItems));
            const newTotalPrice = allGoods.reduce((sum, obj) => obj.price + sum, 0)
            return {
                ...state,
                items: newItems,
                totalCount: allGoods.length,
                totalPrice: newTotalPrice
            }
        }
        case 'CLEAR_CART': {
            return {
                ...state,
                items: action.payload,
                totalPrice: 0,
                totalCount: 0
            }
        }
        case 'REMOVE_GOODS': {
            const newItems = {
                ...state.items,
            }
            delete newItems[action.payload];
            const allGoods = [].concat.apply([], Object.values(newItems));
            const newTotalPrice = allGoods.reduce((sum, obj) => obj.price + sum, 0);
            return {
                ...state,
                items: newItems,
                totalCount: allGoods.length,
                totalPrice: newTotalPrice

            }
        }
        case 'MINUS_ITEM': {
            const newItems = {
                ...state.items,
            }
            newItems[action.payload].splice([0], [1]);
            const allGoods = [].concat.apply([], Object.values(newItems));
            const newTotalPrice = allGoods.reduce((sum, obj) => obj.price + sum, 0);
            return {
                ...state,
                items: newItems,
                totalCount: allGoods.length,
                totalPrice: newTotalPrice

            }
        }

        default :
            return state
    }
}

export default cartReducer