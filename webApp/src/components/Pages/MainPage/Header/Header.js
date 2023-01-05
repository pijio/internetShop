import React from 'react'
import Button from "./Button/Button";
import {Link} from "react-router-dom";
import logo from './logo.png'
import style from './Header.css'

const Header = () => {
    return (
        <div className="header">
            <Link to={'/'}>
                <div className="header__logo">
                    <img className="IS__logo__img" src={logo}
                         alt="Internet shop logo"/>
                </div>
            </Link>
            <div className="container">
                <Button/>
                <div className="header__cart">
                </div>
            </div>
        </div>
    )
}

export default Header