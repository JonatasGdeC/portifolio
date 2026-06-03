import type {AnchorHTMLAttributes} from 'react'
import { LinkStyled, type LinkVariant } from './style'

interface LinkProps extends AnchorHTMLAttributes<HTMLAnchorElement> {
  variant?: LinkVariant
  external?: boolean
}

export function Link({
                       variant = 'default',
                       external = false,
                       children,
                       ...rest
                     }: LinkProps) {
  const externalProps = external
    ? { target: '_blank', rel: 'noreferrer' }
    : {}

  return (
    <LinkStyled $variant={variant} {...externalProps} {...rest}>
      {children}
    </LinkStyled>
  )
}