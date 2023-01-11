import React, {useMemo, useRef, useState} from 'react';
import './AuthForm.css'
import {useHistory} from "react-router-dom";

const AuthForm = () => {
    const [error, setError] = useState("")
    const [method, setMethod] = useState("Auth")
    const usernameRef = useRef();
    const passwordRef = useRef();
    const emailRef = useRef();
    const navigate = useHistory();
    const sumbitAction = (e) => {
        e.preventDefault()
        navigate.push('/')
    }
    const changeMethod = (method) => {
        setMethod(method)
    }
    const inputsForAuth = () => {
        return (
            <>
                <div className="Input">
                    <input type="text" ref={usernameRef} className="Input-text" placeholder="Юзернейм/Email"/>
                    <label htmlFor="input" className="Input-label">Имя пользователя или Email</label>
                </div>
                <div className="Input">
                    <input type="password" ref={passwordRef}  className="Input-text" placeholder="Ваш пароль"/>
                    <label htmlFor="input" className="Input-label">Пароль</label>
                </div>
            </>
        )
    }
    const inputsForReg = () => {
        return (
            <>
                <div className="Input">
                    <input type="text" ref={usernameRef} className="Input-text" placeholder="Ваш юзернейм"/>
                    <label htmlFor="input" className="Input-label">Имя пользователя</label>
                </div>
                <div className="Input">
                    <input type="email" ref={emailRef}  className="Input-text" placeholder="Ваша почта"/>
                    <label htmlFor="input" className="Input-label">Email</label>
                </div>
                <div className="Input">
                    <input type="password" ref={passwordRef}  className="Input-text" placeholder="Ваш пароль"/>
                    <label htmlFor="input" className="Input-label">Пароль</label>
                </div>
                <div className="Input">
                    <input type="password" ref={passwordRef}  className="Input-text" placeholder="Повторите пароль"/>
                    <label htmlFor="input" className="Input-label">Повторите пароль</label>
                </div>
                <div className="SubmitArea">
                    <button className="bn632-hover bn20" onClick={sumbitAction}>Отправить</button>
                </div>
            </>
        )
    }
    const renderedInputs = useMemo(() => {
        method==="Auth" ? inputsForAuth() : inputsForReg()
    }, [method])
    return (
        <div className="WrapperAuth">
            <div className="Form">
                <h1 className="TitleAuth">{"Выберите действие"}</h1>
                <div className="methods">
                    <button className="method" onClick={() => {changeMethod("Reg")}}>Регистрация</button>
                    <button className="method" onClick={() => {changeMethod("Auth")}}>Авторизация</button>
                </div>
                <div className="errors">
                    {error}
                </div>
                {renderedInputs}
            </div>
        </div>
    );
};

export default AuthForm;