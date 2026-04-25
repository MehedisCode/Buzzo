import { createBrowserRouter, Route } from "react-router-dom"

import MainLayout from "../layout/MainLayout";
import HomePage from "../pages/Homepage";

const router = createBrowserRouter([
    {
        path: "/",
        element: <MainLayout />,
        children: [
            {
                path: "/",
                element: <HomePage />
            }
        ]
    }
]);

export default router;