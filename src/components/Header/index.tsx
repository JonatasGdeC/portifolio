import {HeaderContainer, ListLinks} from "./style.tsx";
import {Link} from "../Link";
import {SocialLinks} from "../SocialLinks";

export function Header() {
  return (
    <HeaderContainer>
      <ListLinks>
        <li>
          <Link href="#about">Sobre</Link>
        </li>
        <li>
          <Link href="#projects">Projetos</Link>
        </li>
        <li>
          <Link href="#contact">Contato</Link>
        </li>
      </ListLinks>

      <SocialLinks/>
    </HeaderContainer>
  )
}