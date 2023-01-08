import './ShopForm.css'
import {Link} from "react-router-dom";
import React, {useRef, useState} from "react";
import {useDispatch, useSelector} from "react-redux";
import {makeOrder} from "../../../redux/actions/order";

const ShopForm = () => {

    const {totalPrice, totalCount, items} = useSelector(({cart}) => ({
        totalPrice: cart.totalPrice,
        totalCount: cart.totalCount,
        items: cart.items
    }));
    const groupedFirstItems = Object.keys(items).map(key => {
        return items[key][0]
    });
    const goodsItems = groupedFirstItems.map((item) => item.name)
    const dispatch = useDispatch();
    const customerNameRef = useRef();
    const phoneNumberRef = useRef();
    const detailsRef = useRef();
    const [error, setError] = useState("")
    const sendOrder = (e) => {
        e.preventDefault();
        var customerName = customerNameRef.current.value;
        var phone = phoneNumberRef.current.value;
        var details = detailsRef.current.value;
        var itemsIds = groupedFirstItems.map((item) => item.id)
        if(customerName || phone || details || itemsIds) {
            setError("данные для заказа некорректны")
            return
        }
        dispatch(makeOrder(itemsIds, customerName, phone, details))
    }
    return (
        <div className="Wrapper">
            <h1 className="Title">Оформить заказ</h1>
            <div className="Input">
                <input type="text"  className="Input-text" placeholder="Ваше имя"/>
                    <label htmlFor="input" className="Input-label">Имя</label>
            </div>
            <div className="Input">
                <input type="text"  className="Input-text" placeholder="Ваш номер"/>
                <label htmlFor="input" className="Input-label">Номер телефона</label>
            </div>
            <div className="Input">
                <textarea className="Input-text" placeholder="Ваш адрес и комментарий к заказу"/>
            </div>
            <h4 className="Title">Детали заказа</h4>
            <div className="details">
                <span className="details__title">
                    Выбранные товары:
                </span>
                <br/>
                {goodsItems ? <span className="white">Ничего не выбранно</span> : goodsItems.map((good) => <span className="white">{good}</span>)}
                <br/>
                <span className="details__title">
                    Общая сумма заказа:
                </span>
                <br/>
                <span className="white">{totalPrice ? totalPrice : 0} сом</span>
            </div>
            <div className="SubmitArea">
                <button className="bn632-hover bn20">Отправить</button>
            </div>
        </div>
    )
}
export default ShopForm
