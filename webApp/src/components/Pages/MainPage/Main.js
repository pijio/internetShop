import React from 'react'
import Header from "./Header";
import Slider from "./Slider/Slider";
import Content from "./Content";
import Maps from "./Maps";
import {useDispatch, useSelector} from "react-redux";
import {setCategory} from "../../../redux/actions/filters";
import Contacts from "../GoodsDetailPage/GoodsDetailPageContent/Contacts/Contacts";

const categoryNames = ['Мониторы', "Принтеры", "МФУ", "ПК", "Картириджи", "Ноутбуки"];


const Main = () => {

    const dispatch = useDispatch();
    const onSelectedCategory = React.useCallback(index => {
        dispatch(setCategory(index))
    }, [])
    const {isAuthed, username} = useSelector(({auth}) => auth)
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
            <div>{isAuthed===true ? `Выполнен вход как ${username}` : 'Вход не выполнен'}</div>
        </div>
    )
}
export default Main