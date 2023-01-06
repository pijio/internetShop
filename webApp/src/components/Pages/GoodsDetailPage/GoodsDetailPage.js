import React, {useEffect, useState} from 'react'
import Header from "../MainPage/Header";
import Slider from "../MainPage/Slider/Slider";
import Maps from "../MainPage/Maps";
import GoodsDetailPageContent from "./GoodsDetailPageContent/GoodsDetailPageContent";
import {useDispatch, useSelector} from "react-redux";
import {fetchGoods, setGoods} from "../../../redux/actions/goods";
import Contacts from "./GoodsDetailPageContent/Contacts/Contacts";

const GoodsDetailPage = () => {

    const items = useSelector(({goods}) => goods.items);
    const detail = useSelector(({detail}) => detail.detail);

    const dispatch = useDispatch();

    useEffect(() => {
        window.scrollTo(500, 500)
        dispatch(fetchGoods())
    }, [])

    return (
        <>

            <div className="wrapper">
                <Header/>
                <Slider/>
                {items.filter((item) => {
                    return item.id === detail
                }).map((obj) => (

                    <GoodsDetailPageContent key={obj.id} {...obj}/>
                ))}
                <div className={'footer__contacts'}>
                    <Contacts/>
                </div>
                <Maps/>
            </div>

        </>
    )
}
export default GoodsDetailPage