import React, {useState} from 'react'
import CartButton from "./Buttons/CartButton";
import {Link} from "react-router-dom";
import logo from './logo.png'
import style from './Header.css'
import Modal from "../../../UI/Modal/Modal";
import AuthForm from "../../AuthPages/AuthForm";
import {set} from "express/lib/application";
import AuthButton from "./Buttons/AuthButton";

const Header = () => {
    return (
        <div className="header">
            <Link to={'/'}>
                <div className="header__logo">
                    <img className="IS__logo__img" src={logo}
                         alt="Pijio shop logo"/>
                </div>
            </Link>
            <div className="container">
                <CartButton/>
                <AuthButton/>
                <div className="header__cart">
                </div>
            </div>
        </div>
    )
}

export default Header