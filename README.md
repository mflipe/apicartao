# Teste Técnico - API REST

<!-- wp:paragraph {"align":"justify"} -->
Neste projeto desenvolvi o teste técnico proposto para uma seleção para desenvolvedores. Este teste técnico consiste da elaboração de um artigo em formato de blog de desenvolvimento com as ferramentas <strong><em>C#</em></strong> com <strong><em>.Net Core</em></strong> e <strong><em>Entity Framework Core</em></strong>.
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>Segue o enunciado na integra:</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph {"align":"justify","backgroundColor":"white"} -->
<p class="has-text-align-justify has-white-background-color has-background"><strong><em>Aqui está a descrição do seu teste técnico:</em></strong><br><br><em>Escreva um artigo, em formato de blog post sobre um projeto C# com .NET Core.&nbsp;Você deverá descrever o passo-a-passo para a criação de uma API REST que fornece um sistema de geração de número de cartão de crédito virtual.</em><br><br><em>A API deverá gerar números aleatórios para o pedido de novo cartão. Cada cartão gerado deve estar associado a um e-mail para identificar a pessoa que está utilizando.</em><br><br><em>Essencialmente são 2 endpoints. Um receberá o e-mail da pessoa e retornará um objeto de resposta com o número do cartão de crédito. E o outro endpoint deverá listar, em ordem de criação, todos os cartões de crédito virtuais de um solicitante (passando seu email como parâmetro).</em><br><br><em>A implementação deverá ser escrita utilizando C# com .Net Core e Entity Framework Core.</em></p>
<!-- /wp:paragraph -->

<!-- wp:quote {"align":"center"} -->
<blockquote class="wp-block-quote has-text-align-center"><p>Primeiramente preciso anunciar que <strong>não</strong> tenho nenhum conhecimento em nenhuma das tecnologias solicitadas, portanto vou começar do zero, do começo.</p><cite>Marcos Rocha, O autor</cite></blockquote>
<!-- /wp:quote -->

# Desenvolvimento

Acesse ao a publicação no meu blog para a história completa:
https://marcosfellps.wordpress.com/2021/05/27/teste-tecnico-api-rest/

# Conclusão

<!-- wp:paragraph {"align":"justify"} -->
<p class="has-text-align-justify">Finalmente chegamos ao fim deste teste técnico, é importante destacar que agora entendo como  as ferramentas <strong><code>C#</code></strong> com <strong><code>.Net Core</code></strong> e <strong><code>Entity Framework Core</code></strong> trabalham em conjunto. Mas não se iluda, não me tornei nenhum especialista e me deparei com algumas situações das quais a implementação não foi feita conforme gostaria mas que foram suficientes para a solução proposta dentro do prazo.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph {"align":"justify"} -->
<p class="has-text-align-justify">Acabei deixando um <strong><code>endpoint</code></strong> a mais, o <strong style="font-size: revert;"><code>GET /api/Cartoes/</code></strong>, pois ele foi gerado automaticamente e me ajudou muito no debug durante o desenvolvimento. Remove-lo é tão simples quanto remover seu método na classe <strong><code>Controller</code></strong>.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph {"align":"justify"} -->
<p class="has-text-align-justify">Por fim, gostaria de afirmar que estou otimista com meus resultados e acredito ter cumprido com o teste proposto. Também gostaria de afirmar que minha primeira reação ao ler o desafio e os nomes das tecnologias solicitadas foi o de <em>"deu ruim, como que vou aprender a fazer isso em 3 dias?"</em> mas que mesmo assim resolvi tentar e me convenci que mesmo que não seja aprovado esse conhecimento tem valor.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>Para os que chegaram até aqui, <strong>muito obrigado!</strong></p>
<!-- /wp:paragraph -->
