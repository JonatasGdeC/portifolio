import styled, { css } from 'styled-components'
import {colors} from "../../styles.ts";

export type LinkVariant = 'default' | 'underline' | 'nav' | 'ghost'

const variants = {
  default: css`
    color: ${colors.text};
    transition: opacity 0.2s ease;

    &:hover { opacity: 0.8; }
  `,
  underline: css`
      color: ${colors.text};
      border-bottom: 1px solid ${colors.blue};
      padding-bottom: 4px;
      font-weight: 500;
      transition: transform 0.2s ease, opacity 0.2s ease;

      &:hover {
          transform: translateY(-1px);
          opacity: 0.88;
      }
  `,
  nav: css`
    color: ${colors.textSecondary};
    font-size: 0.9rem;
    transition: color 0.2s ease;

    &:hover { color: ${colors.text}; }
  `,
  ghost: css`
    color: ${colors.blue};
    font-size: 0.92rem;
    font-weight: 500;
    letter-spacing: 0.12em;
    text-transform: uppercase;
    border-bottom: 1px solid ${colors.blue};
    padding-bottom: 5px;
    transition: opacity 0.2s ease;

    &:hover { opacity: 0.82; }
  `,
}

export const LinkStyled = styled.a<{ $variant: LinkVariant }>`
  ${({ $variant }) => variants[$variant]}
`