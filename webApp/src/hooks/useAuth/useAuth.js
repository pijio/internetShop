import React from 'react';
import { useState, useEffect } from 'react';
import apiEndpoint from "../../apiEndpoint";
const useAuth = () => {
    const [isAuth, setAuth] = useState(false)
    useEffect( () => {
        const checkAuth = async () => {
            try {
                const token = localStorage.getItem('authtoken')
                if(!token) {
                    throw new Error();
                }

                const response = await fetch(apiEndpoint+'/verify', {headers: {'Authorization': `Bearer ${token}`}})
                if(!response.ok) {
                    throw new Error();
                }

                setAuth(true);
            } catch (error) {
                localStorage.removeItem('authtoken')
                setAuth(false)
            }
        };
        checkAuth().then();
    }, [])

    return (
        {isAuth}
    );
};

export default useAuth;