import axios from "axios";

export const setLoaded = payload =>({
    type:'SET__LOADED',
    payload
})
export const fetchGoods = (category,sortBy)=>(dispatch)=>{
    dispatch(setLoaded(false))
    if (category===null&&sortBy===2){
        return (
            axios.get(`/ISGoods?inStock=true`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (category===null&&sortBy===1){
        return (
            axios.get(`/ISGoods?_sort=price&_order=asc`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }

    if (category===null&&sortBy===0){
        return (
            axios.get(`/ISGoods?_sort=popular&_order=desc`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }


    if (sortBy===2){
        return (
            axios.get(`/ISGoods?key=${category }&inStock=true`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (sortBy===1){
        return (
            axios.get(`/ISGoods?key=${category}&_sort=price&_order=asc`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
    if (sortBy===0){
        return (
            axios.get(`/ISGoods?key=${category}&_sort=popular&_order=desc`).then(({data})=>{
                dispatch(setGoods(data))
            }).catch(error=>console.log('Интернет включи'))
        )
    }
}
export const setGoods = (items)=>({
    type:'SET_GOODS',
    payload : items
});


