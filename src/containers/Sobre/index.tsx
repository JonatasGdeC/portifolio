import Titulo from '../../components/Titulo'
import Paragrafo from '../../components/Paragrafo'
import { GithubSecao } from './styles'

const Sobre = () => (
  <section>
    <Titulo fontSize={16}>Sobre mim</Titulo>
    <Paragrafo>
      Lorem ipsum dolor sit, amet consectetur adipisicing elit. Porro modi amet
      deleniti, nostrum sunt similique iure facilis doloribus, corporis autem
      eos reprehenderit. Sed reprehenderit minima voluptates. Deleniti commodi
      excepturi molestiae.
    </Paragrafo>
    <GithubSecao>
      <img src="https://github-readme-stats.vercel.app/api?username=jonatasgdec&theme=highcontrast" />
      <img src="https://github-readme-stats.vercel.app/api/top-langs?username=jonatasgdec&layout=compact&langs_count=8&card_width=320&theme=highcontrast" />
    </GithubSecao>
  </section>
)

export default Sobre
