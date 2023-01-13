import './ShopForm.css'
import React, {useRef, useState} from "react";
import {useDispatch, useSelector} from "react-redux";
import {makeOrder} from "../../../redux/actions/order";
import {phoneValidator} from "../../../utils/PhoneValidator"
import { useHistory } from 'react-router-dom';
import {disable} from "express/lib/application";
import {clearCart} from "../../../redux/actions/cartClear";

const ShopForm = ({setVisible}) => {

    const {totalPrice, items} = useSelector(({cart}) => ({
        totalPrice: cart.totalPrice,
        items: cart.items
    }));
    const dispatch = useDispatch()
    const groupedFirstItems = Object.keys(items).map(key => ({ product: items[key][0], count: items[key].length}));
    const customerNameRef = useRef();
    const phoneNumberRef = useRef();
    const detailsRef = useRef();
    const [error, setError] = useState("")
    const navigate = useHistory();
    const sendOrder = (e) => {
        e.preventDefault();
        let customerName = customerNameRef.current.value;
        let phone = phoneNumberRef.current.value;
        let items = groupedFirstItems.map((item) => ({productId: item.product.id, productCount: item.count}))
        let details = detailsRef.current.value;
        if(items === null) {
            setError("В корзине нету товаров. Вернитесь и выберите что нибудь :)")
            return
        }
        if(customerName==="" || details==="") {
            setError("Вы что-то не ввели :(")
            return
        }
        if(!phoneValidator(phone)) {
            setError("Введите номер в формате 0XXXXXXXXX или +996XXXXXXXXX")
            return
        }
        makeOrder(items, customerName, phone, details)
        dispatch(clearCart())
        setVisible(false)
        navigate.push('/')
    }
    return (
            <div className="Wrapper">
                <h1 className="Title">Оформить заказ</h1>
                <div className="errors">
                    {error}
                </div>
                <div className="Input">
                    <input type="text" ref={customerNameRef} className="Input-text" placeholder="Ваше имя"/>
                    <label htmlFor="input" className="Input-label">Имя</label>
                </div>
                <div className="Input">
                    <input type="number" ref={phoneNumberRef}  className="Input-text" placeholder="Ваш номер"/>
                    <label htmlFor="input" className="Input-label">Номер телефона</label>
                </div>
                <div className="Input">
                    <textarea className="Input-text" ref={detailsRef} placeholder="Ваш адрес и комментарий к заказу"/>
                </div>
                <h4 className="Title">Детали заказа</h4>
                <div className="details">
                <span className="details__title">
                    Выбранные товары:
                </span>
                    <br/>
                    {groupedFirstItems === undefined ? <span className="white">Ничего не выбранно</span> : groupedFirstItems.map((good) => <span className="white">{good.product.name} - {good.count} шт.</span>)}
                    <br/>
                    <span className="details__title">
                    Общая сумма заказа:
                    </span>
                    <br/>
                    <span className="white">{totalPrice ? totalPrice : 0} сом</span>
                </div>
                <div className="SubmitArea">
                    <button className="bn632-hover bn20" onClick={sendOrder}>Отправить</button>
                </div>
            </div>
    )
}
export default ShopForm
