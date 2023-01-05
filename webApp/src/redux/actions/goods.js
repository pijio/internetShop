import axios from "axios";

export const setLoaded = payload =>({
    type:'SET__LOADED',
    payload
})
export const fetchGoods = (category,sortBy)=>(dispatch)=>{
    dispatch(setLoaded(false))
    var baseurl = "https://localhost:5001"
    if (category===null&&sortBy===2){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (category===null&&sortBy===1){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }

    if (category===null&&sortBy===0){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }


    if (sortBy===2){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (sortBy===1){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (sortBy===0){
        return (
            axios.get(baseurl+'/shop/products').then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
}
export const setGoods = (items)=>({
    type:'SET_GOODS',
    payload : items
});


