import styled, { css } from 'styled-components'
import { colors } from '../../styles'

type Variant = 'heading' | 'subheading' | 'body' | 'caption' | 'eyebrow'
type Color = 'primary' | 'secondary' | 'blue' | 'muted'

export type { Variant, Color }

const variants = {
  heading: css`
      font-size: clamp(2rem, 4vw, 3.4rem);
      font-weight: 700;
      letter-spacing: -0.04em;
      line-height: 0.95;
  `,
  subheading: css`
      font-size: clamp(1.4rem, 3vw, 2rem);
      font-weight: 700;
      letter-spacing: -0.04em;
  `,
  body: css`
      font-size: 0.95rem;
      line-height: 1.8;
  `,
  caption: css`
      font-size: 0.84rem;
  `,
  eyebrow: css`
      font-size: 0.78rem;
      font-weight: 600;
      letter-spacing: 0.12em;
      text-transform: uppercase;
  `,
}

const colorMap = {
  primary:   colors.text,
  secondary: colors.textSecondary,
  blue:      colors.blue,
  muted:     colors.gray,
}

export const TextStyled = styled.p<{ $variant: Variant; $color: Color }>`
    ${({ $variant }) => variants[$variant]}
    color: ${({ $color }) => colorMap[$color]};
`