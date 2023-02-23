// assets
import { LaptopChromebookRounded, Help } from '@mui/icons-material';

// constant
const icons = { LaptopChromebookRounded, Help };

// ==============================|| SAMPLE PAGE & DOCUMENTATION MENU ITEMS ||============================== //

const other = {
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
};

export default other;
