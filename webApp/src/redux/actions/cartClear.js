export const clearCart = (empty)=>({
    type : 'CLEAR_CART',
    payload : empty
});
export const removeGoods = (id)=>({
    type : 'REMOVE_GOODS',
    payload : id
});