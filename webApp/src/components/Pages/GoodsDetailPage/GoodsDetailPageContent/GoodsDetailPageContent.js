import React, {useEffect, useRef, useState} from 'react'
import './GoodsDetailPageContent.css'
import {Link} from "react-router-dom";
import Contacts from "./Contacts/Contacts";
import VideoReview from "./VideoReview/VideoReview";
import {useDispatch, useSelector} from "react-redux";
import {fetchGoods} from "../../../../redux/actions/goods";

const GoodsDetailPageContent = ({   scrollRef,
                                    name,
                                    key,
                                    videoUrl,
                                    os,
                                    screenSizes,
                                    processor,
                                    imageUrl,
                                    ram,
                                    imageUrl1,
                                    imageUrl2,
                                    imageUrl3,
                                    price,
                                    inStock,
                                    title,
                                    popular,
                                    disc,
                                    printer_ram,
                                    dpi,
                                    type,
                                    format,
                                    ppm
                                }) => {

    const {sortBy} = useSelector(({filters}) => filters);
    const dispatch = useDispatch();
    const category = key
    const executeScroll = () => scrollRef.current.scrollIntoView()
    useEffect(() => {
        document.body.addEventListener('click', handleOutsideClick);
        document.body.addEventListener('click', handleOutsideClick1);
    }, [])
    const sortRef = useRef(() => {
    });
    const sortRef2 = useRef(() => {
    });


    const [video, setVideo] = useState(false);

    const setVideoFalse = (index) => {
        setVideo(index)
    }

    const [active, setActive] = useState(null);
    const onItemClick = (index) => {
        setActive(index);
    }
    const onContactClick = () => {
        scrollRef.current.scrollIntoView();
    };
    const handleOutsideClick = (event) => {
        const path = event.path || (event.composedPath && event.composedPath()) || event.composedPath(event.target);
    };
    const handleOutsideClick1 = (event) => {
        const path = event.path || (event.composedPath && event.composedPath()) || event.composedPath(event.target);
    };
    console.log(videoUrl)

    return (

        <div className="wrapper">


            <div className="container mh">
                <div className="toHome">
                    <Link to={'/'}>
                        <img className={'toHome__Button'} src="https://cdn-icons-png.flaticon.com/512/6298/6298551.png"
                             alt=""/>
                    </Link>
                </div>
                <div className="goods__name">
                    <h1 className="h1__goods__name">{name}</h1>
                    <h2 className="h1__goods__name">???????????????????????????? ?? ???????????????? ????????????</h2>

                    <div className="items__title__block">
                        <Link to={'/'}>
                            <div className="items__title__content">???? ??????????????</div>
                        </Link>

                        <div ref={sortRef2} onClick={() => onContactClick()}
                             className="items__title__content">???????? ????????????????
                        </div>
                        <div onClick={() => setVideoFalse(!video)} className="items__title__content">??????????-??????????</div>
                        {video ? <VideoReview videoUrl={videoUrl} setVideoFalse={setVideoFalse}/> : ''}
                        <Link to={'/'}>
                            <div className="items__title__content">?????????????????? ??????????</div>
                        </Link>


                    </div>

                </div>
                <div className="content">
                    <div className="photo__block">
                        <div className="photo__item scale">
                            <img
                                src={active === null ? imageUrl : active === 1 ? imageUrl1 : active === 2 ? imageUrl2 : active === 3 ? imageUrl3 : ''}
                                alt="" className="photo"/>

                        </div>
                        <div className="mini__photos">
                            <div className="mini__photo">
                                <img onClick={() => onItemClick(null)} className="mini__photo__img" src={imageUrl}
                                     alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={() => onItemClick(1)}
                                    className="mini__photo__img"
                                    src={imageUrl1} alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={() => onItemClick(2)}
                                    className="mini__photo__img"
                                    src={imageUrl2} alt=""/>
                            </div>
                            <div className="mini__photo">
                                <img
                                    onClick={() => onItemClick(3)}
                                    className="mini__photo__img"
                                    src={imageUrl3} alt=""/>
                            </div>

                        </div>
                    </div>
                    <div className="info__block">
                        <p className="aviable margin10px"><p className={'bold'}>??
                            ??????????????</p> {inStock === true ? '???' : '???'}</p>
                        <p className="summ margin10px bold">?????????????????? <p className={'priceStyles'}>{price}</p> c????</p>

                        <p className="little__title__of__goods margin10px">
                            {title}
                        </p>
                        <h4 className="harakteristics margin10px">
                            ????????????????????????????
                        </h4>
                        <p className="p__harakreristics boldHar"> {processor ? `??????????????????: ${processor}`  : ''} </p>
                        <p className="p__harakreristics boldHar"> {screenSizes ? `?????????????????? ????????????: ${screenSizes}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {ram ? `??????: ${ram}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {disc ? `????????????: ${disc}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {os ? `??????????????????????: ${os}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {printer_ram ? `??????: ${printer_ram}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {dpi ? `DPI: ${dpi}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {type ? `??????: ${type}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {format ? `????????????: ${format}` : ''} </p>
                        <p className="p__harakreristics boldHar"> {ppm ? `??????????????????????????: ${ppm}` : ''} </p>

                        <div className="star__rating margin10px">
                            <p className={'bold'}>?????????????? ?????????????????????? : </p>
                            {'???'.repeat(popular)}</div>
                    </div>
                </div>
            </div>
        </div>
    )
}
export default GoodsDetailPageContent