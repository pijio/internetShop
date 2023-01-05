export const addGoodsToCart = (obj)=>({
    type : 'ADD_GOODS_CART',
    payload : obj
});

export const minusItemFromCart = (id)=>({
    type : 'MINUS_ITEM',
    payload : id
});



