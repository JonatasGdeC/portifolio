import styled from 'styled-components'
import { colors } from '../../styles'

export const TagContainer = styled.div`
    background-color: ${colors.purple};
    color: ${colors.text};
    display: inline-block;
    position: absolute;
    top: 0;
    left: 0;
    margin: 10px;
    padding: 4px 8px;
    border-radius: 4px;
    font-size: 0.7rem;
    font-weight: 600;
    letter-spacing: 0.08em;
    text-transform: uppercase;
`
