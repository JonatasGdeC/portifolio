import {ListSocialLinks} from "./style.ts";
import {Link} from "../Link";

import linkedinIcon from "../../assets/imagens/linkedin.svg";
import githubIcon from "../../assets/imagens/github.svg";

export function SocialLinks() {
  return (
    <ListSocialLinks>
      <li>
        <Link href="https://www.linkedin.com/in/jonatasgdec/" external>
          <img src={linkedinIcon} alt="Github" />
        </Link>
        <Link href="https://github.com/JonatasGdeC" external>
          <img src={githubIcon} alt="Github" />
        </Link>
      </li>
    </ListSocialLinks>
  )
}