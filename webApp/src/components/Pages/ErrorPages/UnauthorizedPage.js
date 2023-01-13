import React from 'react';
import ErrorPage from "./ErrorPage";

const NotFoundPage = () => {
    return (
        <ErrorPage errormsg={"Вы не авторизованы для доступа к этой странице"}/>
    );
};

export default NotFoundPage;