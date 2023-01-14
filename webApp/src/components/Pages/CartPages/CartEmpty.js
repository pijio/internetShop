import React from "react";
import Header from "../MainPage/Header";
import Slider from "../MainPage/Slider/Slider";
import Maps from "../MainPage/Maps";
import {Link} from "react-router-dom";
import Contacts from "../GoodsDetailPage/GoodsDetailPageContent/Contacts/Contacts";
const CartEmpty = () => {
    return (

        <>
            <div className="wrapper">
                <Header/>
                <Slider/>
                <div className="content_cart">
                    <div className="container container--cart">
                        <div className="cart">
                            <div className="cart__top">
                            </div>
                            <div className="content__items">


                            </div>
                            <div className="cart__bottom">
                                <div className="cart__bottom-details">
                                    <div className="cart cart--empty">
                                        <h2>Корзина пустая
                                            <icon>	&#129392;</icon>
                                        </h2>
                                        <p>
                                            Вероятней всего, Вы не добавили товар в корзину.<br/> Для того, чтобы сделать это,
                                            перейдите на главную страницу.
                                        </p>
                                        <img src="https://image.freepik.com/free-vector/woman-at-computer-illustration_33099-601.jpg" alt="Empty cart"/>
                                        <Link to={'/'}>
                                        <span  className="button button--outline button--add go-back-btn">
                                        <svg width="8" height="14" viewBox="0 0 8 14" fill="none"
                                             xmlns="http://www.w3.org/2000/svg">
                                            <path d="M7 13L1 6.93015L6.86175 1" stroke="#D3D3D3" strokeWidth="1.5"
                                                  strokeLinecap="round" strokeLinejoin="round"/>
                                        </svg>

                                        <span>Вернуться назад</span>
                                    </span>
                                        </Link>
                                    </div>
                                </div>
                                <div className="cart__bottom-buttons">

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className={'footer'}>
                    <Contacts/>
                    <Maps/>
                </div>
            </div>

        </>


    )
}

export default CartEmpty