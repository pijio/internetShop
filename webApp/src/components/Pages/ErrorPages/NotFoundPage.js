import React from 'react';
import ErrorPage from "./ErrorPage";

const NotFoundPage = () => {
    return (
        <ErrorPage errormsg={"Страница не найдена"}/>
    );
};

export default NotFoundPage;