import React from 'react'
import Header from "./Header";
import Slider from "./Slider/Slider";
import Content from "./Content";
import Maps from "./Maps";
import {useDispatch} from "react-redux";
import {setCategory} from "../../../redux/actions/filters";
import Contacts from "../GoodsDetailPage/GoodsDetailPageContent/Contacts/Contacts";

const categoryNames = ['Мониторы', "Принтеры", "МФУ", "ПК", "Картириджи", "Ноутбуки"];


const Main = () => {

    const dispatch = useDispatch();
    const onSelectedCategory = React.useCallback(index => {
        dispatch(setCategory(index))
    }, [])

    return (
        <div className="wrapper">
            <Header/>
            <Slider/>
            <Content
                onClickItem={onSelectedCategory}
                items={categoryNames}
            />
            <div className={'footer__contacts'}>
                <Contacts/>
            </div>
            <Maps/>

        </div>
    )
}
export default Main