# Prática 03 Aplicação na Nuvem - IaaS

## Equipe
<ul>
  <li>Francisco Airton Araújo Júnior 2023010960</li>
  <li>Jorge Pereira de Oliveira 2023011027</li>
  <li>Rafael Guimarães Januário 2023010600</li>
</ul>

## Descrição da API - Gestão de Usuários

<p>
  A API foi desenvolvida como parte de uma aplicação em Docker Compose, hospedada em uma instância EC2 da AWS. 
  Ela consiste em dois serviços principais: uma aplicação web usando ASP.NET Core e um banco de dados MySQL. 
  A aplicação tem como objetivo demonstrar a interação entre uma API REST e um banco de dados, permitindo o gerenciamento e consulta de usuários cadastrados.
</p>

## Funcionalidade Principal
<p>
  A API expõe um endpoint que permite a consulta de todos os usuários cadastrados no banco de dados. Ao acessar a rota principal, a 
  API faz uma consulta à tabela de usuários, que contém informações como id, nome e matricula. 
  Em seguida, o resultado dessa consulta é retornado no formato JSON.
</p>
