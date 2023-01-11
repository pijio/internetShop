import axios from "axios";
import apiEndpoint from "../../apiEndpoint";

export const setLoaded = payload =>({
    type:'SET__LOADED',
    payload
})
export const fetchGoods = (category,sortBy)=>(dispatch)=>{
    dispatch(setLoaded(false))
    return (
        axios.get(`${apiEndpoint}/shop/filtredProducts?category=${category!=null ? category : ""}&order=${sortBy}&direction=false`).then(({data})=>{
            dispatch(setGoods(data))
        }).catch(error=>console.log('Интернет включи')));
}
export const setGoods = (items)=>({
    type:'SET_GOODS',
    payload : items
});


