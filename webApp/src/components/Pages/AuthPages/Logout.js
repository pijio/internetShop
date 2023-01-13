import React from 'react';
import {useDispatch, useSelector} from "react-redux";
import {setAuthed, setUserName} from "../../../redux/actions/auth";
import {Redirect} from "react-router-dom";

const Logout = () => {
    const dispatch = useDispatch()
    localStorage.removeItem('username')
    localStorage.removeItem('authtoken')
    dispatch(setUserName(''))
    dispatch(setAuthed(false))
    return (
        <Redirect to={'/'}/>
    );
};

export default Logout;