import styled from "styled-components";
import { colors } from '../../styles'

export const ListSocialLinks = styled.ul`
    display: flex;
    align-items: center;
    gap: 8px;
    
    a {
        display: inline-flex;
        align-items: center;
        justify-content: center;
        width: 40px;
        height: 40px;
        color: ${colors.text};
        transition: transform 0.2s ease, opacity 0.2s ease, background-color 0.2s ease, color 0.2s ease;
    }

    img {
        width: 24px;
        height: 24px;
    }
`
