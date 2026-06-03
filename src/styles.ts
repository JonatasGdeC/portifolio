import { createGlobalStyle } from 'styled-components'

export const colors = {
    bg: '#211c1d',
    text: '#f5f0ea',
    textSecondary: '#d9d2cb',
    blue: '#b5c8da',
    blueDark: '#7f95ab',
    blueLight: '#d7e4ef',
    purple: '#554bc2',
    purpleHover: '#6b60d4',
    green: '#78b286',
    gray: '#b9b1ab',
    grayDark: '#8b8580',
}

export const breakpoints = {
    desktop: '1024px',
    tablet: '768px'
}

export const GlobalCss = createGlobalStyle`
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
        font-family: 'Poppins', 'Segoe UI', sans-serif;
        list-style: none;
        scroll-behavior: smooth;
        outline: none;
        text-decoration: none;
    }

    body {
        background-color: ${colors.bg};
        color: ${colors.text};
        width: min(100%, 1100px);
        margin: 0 auto;

        @media (max-width: ${breakpoints.desktop}) {
            max-width: 80%;
        }
    }
`
