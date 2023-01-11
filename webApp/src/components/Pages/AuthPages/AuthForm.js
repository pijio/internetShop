import React, {useCallback, useEffect, useMemo, useRef, useState} from 'react';
import './AuthForm.css'
import {useHistory} from "react-router-dom";
import AuthAction from "./Auth.Action";

const AuthForm = () => {
    const [error, setError] = useState("")
    const [method, setMethod] = useState("Auth")
    const [username, setUsername] = useState('')
    const [password, setPassword] = useState('')
    const [confirmPwd, setConfirmPwd] = useState('')
    const [email, setEmail] = useState('')
    const [employeeSecret, setSecret] = useState('')
    const [isSuccess, setSuccess] = useState(false)
    const usernameRef = useRef(username)
    const passwordRef = useRef(password)
    const confirmPwdRef = useRef(confirmPwd)
    const emailRef = useRef(email)
    const secretRef = useRef(employeeSecret)
    const navigate = useHistory();
    const changeMethod = (method) => {
        setError('');
        passwordRef.current.value = "";
        setMethod(method)
    }
    const inputsForAuth = () => {
        return (
            <>
                <div className="Input">
                    <input type="text" ref={usernameRef} onChange={() => setUsername(usernameRef.current.value)}
                           className="Input-text" placeholder="Юзернейм/Email"/>
                    <label htmlFor="input" className="Input-label">Имя пользователя или Email</label>
                </div>
                <div className="Input">
                    <input type="password" ref={passwordRef} onChange={() => setPassword(passwordRef.current.value)}
                           className="Input-text" placeholder="Ваш пароль"/>
                    <label htmlFor="input" className="Input-label">Пароль</label>
                </div>
            </>
        )
    }
    const inputsForReg = () => {
        return (
            <>
                <div className="Input">
                    <input type="text" ref={usernameRef} onChange={() => {
                        setUsername(usernameRef.current.value)
                    }} className="Input-text" placeholder="Ваш юзернейм"/>
                    <label htmlFor="input" className="Input-label">Имя пользователя</label>
                </div>
                <div className="Input">
                    <input type="email" ref={emailRef} onChange={() => setEmail(emailRef.current.value)}
                           className="Input-text" placeholder="Ваша почта"/>
                    <label htmlFor="input" className="Input-label">Email</label>
                </div>
                <div className="Input">
                    <input type="password" ref={passwordRef} onChange={() => setPassword(passwordRef.current.value)}
                           className="Input-text" placeholder="Ваш пароль"/>
                    <label htmlFor="input" className="Input-label">Пароль</label>
                </div>
                <div className="Input">
                    <input type="password" ref={confirmPwdRef}
                           onChange={() => setConfirmPwd(confirmPwdRef.current.value)} className="Input-text"
                           placeholder="Повторите пароль"/>
                    <label htmlFor="input" className="Input-label">Повторите пароль</label>
                </div>
                <div className="Input">
                    <input type="text" ref={secretRef} onChange={() => setSecret(secretRef.current.value)}
                           className="Input-text" placeholder="Секретный ключ сотрудников"/>
                    <label htmlFor="input" className="Input-label">Секретный ключ</label>
                </div>
            </>
        )
    }
    const [fields, setFields] = useState(inputsForAuth())
    useEffect(() => {
        setError('');
        method === "Auth" ? setFields(inputsForAuth) : setFields(inputsForReg);
    }, [method])

    const getValidator = (method) => {
        return method === "Auth" ? (name, pass) => {
                if (name !== "" && pass !== "")
                    return true;
                setError("Вы что-то не ввели...")
                return false
            } :
            (name, pass, passconf, mail, secr) => {
                if (name !== "" && pass !== "" && passconf !== "" && mail !== "" && secr !== "") {
                    if (pass === passconf)
                        return true
                    else {
                        setError("Введеные пароли не совпадают")
                        return false;
                    }
                }
                setError("Вы что-то ввели")
                return false
            }
    }
    const validator = useMemo(() => {
        return getValidator(method)
    }, [method])
    const sumbitAction = (e) => {
        if (!validator(username, password, confirmPwd, email, secretRef)) {
            return;
        }
        const payload = method === "Auth" ? {username: username, password: password} : {
            username: username,
            password: password,
            email: email,
            secretKey: employeeSecret
        }
        const endpoint = method === "Auth" ? "/auth" : "/register"

    }
    return (
        <div className="WrapperAuth">
            <div className="Form">
                <h1 className="TitleAuth">{"Выберите действие"}</h1>
                <div className="methods">
                    <button className="method" onClick={() => {
                        changeMethod("Reg")
                    }}>Регистрация
                    </button>
                    <button className="method" onClick={() => {
                        changeMethod("Auth")
                    }}>Авторизация
                    </button>
                </div>
                <div className="errors">
                    {error}
                </div>
                {fields}
                <div className="SubmitArea">
                    <button className="bn632-hover bn20" onClick={sumbitAction}>Отправить</button>
                </div>
            </div>
        </div>
    );
};

export default AuthForm;