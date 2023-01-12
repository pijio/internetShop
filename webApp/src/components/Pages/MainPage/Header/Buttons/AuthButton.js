import React, {useEffect, useState} from 'react';
import {useSelector} from "react-redux";
import {Link, useHistory} from "react-router-dom";
import LogoutSvg from "./Logout.svg";
import LoginSvg from "./Login.svg";

const AuthButton = () => {
    const getPath = (authed) => {
        return (authed ? "/logout" : "/auth" )
    }
    const [isAuthed, setAuthed] = useState(!!localStorage.getItem('authtoken'))
    const [redirectPath, setPath] = useState(getPath(isAuthed))
    const [btnSvg, setSvg] = useState(isAuthed ? <LogoutSvg/> : <LoginSvg/>)
    const handleClick = (e) => {
        setPath(getPath(isAuthed))
    }
    return (
        <Link to={redirectPath}>
            <button className="button button--cart button--loggin" onClick={handleClick}>
                {btnSvg}
            </button>
        </Link>
    );
};

export default AuthButton;