import React, {useEffect, useRef, useState} from 'react'
import './GoodsDetailPageContent.css'
import {Link} from "react-router-dom";
import Contacts from "./Contacts/Contacts";
import VideoReview from "./VideoReview/VideoReview";
import {useDispatch, useSelector} from "react-redux";
import {fetchGoods} from "../../../../redux/actions/goods";

const GoodsDetailPageContent =  ({name,key,videoUrl,os,screenSizes,processor,imageUrl,ram,imageUrl1,imageUrl2,imageUrl3,price,inStock,title,popular,disc})=>{

    const {sortBy} = useSelector(({filters})=>filters);
    const dispatch = useDispatch();
    const category=key








    useEffect(()=>{
        document.body.addEventListener('click',handleOutsideClick);
        document.body.addEventListener('click',handleOutsideClick1);
    },[])
    const sortRef = useRef(()=>{
    });
    const sortRef2 = useRef(()=>{
    });


    const [video,setVideo] = useState(false);

    const setVideoFalse = (index)=>{
        setVideo(index)
    }

    const [active,setActive] = useState(null);
    const onItemClick = (index)=>{
        setActive(index);
    }
    const [contact,setContact] = useState(false);
    const onContactClick = (index)=>{
        setContact(index);
    };
    const handleOutsideClick = (event) =>{
        const path = event.path || (event.composedPath && event.composedPath()) || event.composedPath(event.target);
        if (!path.includes(sortRef.current)){
            setContact(false);
        }
    };
    const handleOutsideClick1 = (event) =>{
        const path = event.path || (event.composedPath && event.composedPath()) || event.composedPath(event.target);
        if (path.includes(sortRef2.current)){
            setContact(true);
        }
    };
    console.log(videoUrl)

    return (

        <div className="wrapper">
            <div className="toHome">
                <Link to={'/'}>
                    <img className={'toHome__Button'} src="https://cdn-icons-png.flaticon.com/512/6298/6298551.png" alt=""/>
                </Link>
            </div>

            <div className="container mh">
                <div className="goods__name">
                    <h1 className="h1__goods__name">{name}</h1>
                    <h2 className="h1__goods__name">Характеристики и описание товара</h2>

                    <div className="items__title__block">
                        <Link to={'/'}>
                            <div className="items__title__content">На главную</div>
                        </Link>

                        <div ref={sortRef2} onClick={()=>onContactClick(!contact)} className="items__title__content">Наши контакты</div>
                        {<Contacts contact={contact} sortRef={sortRef}/>}
                        <div onClick={()=>setVideoFalse(!video)} className="items__title__content">Видео-обзор</div>
                        {video?<VideoReview videoUrl={videoUrl} setVideoFalse={setVideoFalse}/>:''}
                        <a href="http://www.shop.IS.kg"> <div className="items__title__content">Сервисный центр</div></a>



                    </div>

                </div>
                <div className="content">
                    <div className="photo__block">
                        <div className="photo__item scale">
                            <img src={active===null?imageUrl:active===1?imageUrl1:active===2?imageUrl2:active===3?imageUrl3:''} alt="" className="photo"/>

                        </div>
                        <div className="mini__photos">
                            <div  className="mini__photo">
                                <img onClick={()=>onItemClick(null)} className="mini__photo__img" src={imageUrl} alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={()=>onItemClick(1)}
                                    className="mini__photo__img"
                                     src={imageUrl1} alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={()=>onItemClick(2)}
                                    className="mini__photo__img"
                                     src={imageUrl2} alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={()=>onItemClick(3)}
                                    className="mini__photo__img"
                                     src={imageUrl3} alt=""/>
                            </div>

                        </div>
                    </div>
                    <div className="info__block">
                        <p className="aviable margin10px"> <p className={'bold'}>В наличии</p> {inStock===true?'✅':'❌'}</p>
                        <p className="summ margin10px bold">Стоимость <p className={'priceStyles'}>{price}</p> cом</p>

                        <p className="little__title__of__goods margin10px">
                            {title}
                        </p>
                        <h4 className="harakteristics margin10px">
                            Характеристики
                        </h4>
                        <p className="p__harakreristics boldHar margin10px">
                            {processor? `Процессор: ${processor}`:''}  <br/>{screenSizes? `Диагональ экрана: ${screenSizes}`:''} <br/> {ram? `ОЗУ: ${ram}`:''} <br/>
                            {disc? `Память: ${disc}`:''} <br/> {os? `Операционка: ${os}`:''} <br/> Видеократа : Дискретная
                        </p>
                        <div className="star__rating margin10px">
                            <p className={'bold'}>Рейтинг покупателей : </p>
                            {'⭐'.repeat(popular)}</div>
                    </div>
                </div>
            </div>
        </div>
    )
}
export default GoodsDetailPageContent