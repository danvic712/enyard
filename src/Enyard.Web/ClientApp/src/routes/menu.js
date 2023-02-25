// assets
import { Dashboard, LaptopChromebookRounded, Help, Key } from "@mui/icons-material";

// constant
const icons = { Dashboard, LaptopChromebookRounded, Help, Key };

const menuItems = {
    items: [
        {
            id: 'dashboard',
            title: 'Dashboard',
            type: 'group',
            children: [
                {
                    id: 'default',
                    title: 'Dashboard',
                    type: 'item',
                    url: '/dashboard',
                    icon: icons.Dashboard,
                    breadcrumbs: false
                }
            ]
        },
        {
            id: 'pages',
            title: 'Pages',
            caption: 'Pages Caption',
            type: 'group',
            children: [
                {
                    id: 'authentication',
                    title: 'Authentication',
                    type: 'collapse',
                    icon: icons.Key,
                    children: [
                        {
                            id: 'login3',
                            title: 'Login',
                            type: 'item',
                            url: '/pages/login/login3',
                            target: true
                        },
                        {
                            id: 'register3',
                            title: 'Register',
                            type: 'item',
                            url: '/pages/register/register3',
                            target: true
                        }
                    ]
                }
            ]
        },
        {
            id: 'sample-docs-roadmap',
            type: 'group',
            children: [
                {
                    id: 'sample-page',
                    title: 'Sample Page',
                    type: 'item',
                    url: '/sample-page',
                    icon: icons.LaptopChromebookRounded,
                    breadcrumbs: false
                },
                {
                    id: 'documentation',
                    title: 'Documentation',
                    type: 'item',
                    url: 'https://github.com/danvic712/enyard/wiki',
                    icon: icons.Help,
                    external: true,
                    target: true
                }
            ]
        }
    ]
};

export default menuItems;