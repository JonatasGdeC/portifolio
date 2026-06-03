import type {ElementType} from 'react'
import {TextStyled, type Variant, type Color} from './style'

interface TextProps {
  as?: ElementType
  variant?: Variant
  color?: Color
  children: React.ReactNode
  className?: string
}

export function Text({
                       as = 'p',
                       variant = 'body',
                       color = 'primary',
                       children,
                       className,
                     }: TextProps) {
  return (
    <TextStyled
      as={as}
      $variant={variant}
      $color={color}
      className={className}
    >
      {children}
    </TextStyled>
  )
}