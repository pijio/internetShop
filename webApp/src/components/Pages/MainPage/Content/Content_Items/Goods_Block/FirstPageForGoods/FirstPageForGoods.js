import React from 'react'
import '../isLoad.css'
import {Link} from "react-router-dom";
import {useDispatch} from "react-redux";
import {setDetail} from "../../../../../../../redux/actions/details";
import {addGoodsToCart} from "../../../../../../../redux/actions/cart";





const Noteboks = ({cartCount,id,name,imageUrl,processor,ram,os,category,disc,price,ppm,type,dpi,format,printer_ram,inStock}) =>{

const dispatch = useDispatch()




    const addId = ()=>{
        dispatch(setDetail(id))
    }

    const onAddGoods = ()=>{
    const obj = {
        id,
        name,
        imageUrl,
        price,
        ram,
        printer_ram,
        type,
        processor,
        os


    }

        dispatch(addGoodsToCart(obj))
    }





    return (
        <>
        <div   className = "pizza-block" >
            <div className={''}>
                <Link to={'/details'}>
                    {inStock===true?<img className={'in__stock'} src="https://vrn.spcity-friends.ru/files/8a6/8a64bbf7b5e354465415d7db298bd1f7.png" alt=""/>:
                        <img className={'in__stock2'}  src="https://волгаас.рф/images/image/baners/im_988.png" alt=""/>}

                    <img onClick={addId}  className = "pizza-block__image hover__notebooks"
                           src = {imageUrl}
                           alt = "Pizza"/>
                    <h4 className={'p__more__info' }> ПОДРОБНЕЕ</h4>

                </Link>


                <h4 className = "pizza-block__title" > {name} </h4>
            </div>
            <div className = "pizza-block__selector" >
                <ul >
                    <li > {processor}{ppm} {} </li>
                    <li > {ram} {type}  </li>
                </ul>
                <ul>
                    <li  > {os} {dpi} </li>
                    <li > {category} {format} </li>
                    <li > {disc} {printer_ram} </li>
                </ul>
            </div>
            <div className = "pizza-block__bottom" >
                <div className = "pizza-block__price" >от {price} сом </div>
                <div onClick={onAddGoods} className = "button button--outline button--add" >
                    <svg width = "12"
                         height = "12"
                         viewBox = "0 0 12 12"
                         fill = "none"
                         xmlns = "http://www.w3.org/2000/svg" >
                        <path d = "M10.8 4.8H7.2V1.2C7.2 0.5373 6.6627 0 6 0C5.3373 0 4.8 0.5373 4.8 1.2V4.8H1.2C0.5373 4.8 0 5.3373 0 6C0 6.6627 0.5373 7.2 1.2 7.2H4.8V10.8C4.8 11.4627 5.3373 12 6 12C6.6627 12 7.2 11.4627 7.2 10.8V7.2H10.8C11.4627 7.2 12 6.6627 12 6C12 5.3373 11.4627 4.8 10.8 4.8Z"
                              fill = "white"/>
                    </svg>
                    <span> Добавить </span>
                    <i >{cartCount}</i>
                </div>
            </div>
        </div>
</>

)
}


export default Noteboks
