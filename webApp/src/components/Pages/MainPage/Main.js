import React from 'react'
import Header from "./Header";
import Slider from "./Slider/Slider";
import Content from "./Content";
import Maps from "./Maps";
import {useDispatch} from "react-redux";
import {setCategory} from "../../../redux/actions/filters";
import Contacts from "../GoodsDetailPage/GoodsDetailPageContent/Contacts/Contacts";
import authReducer from "../../../redux/redusers/auth";
import useAuth from "../../../hooks/useAuth/useAuth";
import {setAuthed} from "../../../redux/actions/auth";

const categoryNames = ['Мониторы', "Принтеры", "МФУ", "ПК", "Картириджи", "Ноутбуки"];


const Main = () => {

    const dispatch = useDispatch();
    const onSelectedCategory = React.useCallback(index => {
        dispatch(setCategory(index))
    }, [])
    const {isAuth} = useAuth()
    dispatch(setAuthed(isAuth))
    console.log(isAuth)
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
            <div>{isAuth ? 'Выполнен вход' : 'Вход не выполнен'}</div>
        </div>
    )
}
export default Main