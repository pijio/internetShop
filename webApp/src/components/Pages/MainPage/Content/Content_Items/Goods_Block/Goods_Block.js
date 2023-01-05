import React, {useEffect} from "react";
import Noteboks from "./FirstPageForGoods";
import {useDispatch, useSelector} from "react-redux";
import {fetchGoods} from "../../../../../../redux/actions/goods";
import IsLoad from "./IsLoad";




const Goods_Block = ()=>{
    const items = useSelector(({goods})=>goods.items);
    const cartItems = useSelector(({cart})=>cart.items);
    const isLoad = useSelector(({goods})=>goods.isLoaded);
    const {category,sortBy} = useSelector(({filters})=>filters);

    const dispatch = useDispatch();

    useEffect(()=>{
        dispatch(fetchGoods(category,sortBy))
    },[sortBy,category])

    const getRandom = (max)=>{
        return Math.floor(Math.random() * max);
    }

    return (
        <>
            {isLoad?items.map((obj)=>(
                <Noteboks cartCount={cartItems[obj.id]?cartItems[obj.id].length:0} key={obj.id} {...obj}/>
            )):<IsLoad key={getRandom(99999999)}/>}
        </>
    )
}


export default Goods_Block



