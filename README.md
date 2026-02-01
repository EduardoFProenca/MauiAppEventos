# 📅 MauiAppEventos

Aplicativo multiplataforma para cadastro e gerenciamento de eventos, desenvolvido com .NET MAUI.

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como **Agenda 15** da disciplina de **Desenvolvimento de Sistemas II** na ETEC, sob orientação do professor **Argeli Pedro de Lima**. O aplicativo permite o cadastro completo de eventos, incluindo cálculo automático de custos baseado no número de participantes, duração e custo por pessoa.

### 🎓 Informações Acadêmicas

- **Disciplina**: Desenvolvimento de Sistemas II
- **Atividade**: Agenda 15 - Avaliação
- **Professor**: Argeli Pedro de Lima
- **Data da Avaliação**: 03/06/2025
- **Menção**: MB (Muito Bom)
- **Feedback do Professor**: "Olá, Eduardo. Tudo bem? Seu Aplicativo ficou funcional, mas o destaque fica por conta do Design criado para ele. Parabéns pelo resultado."

## 📸 Screenshots

<p  align="center">
  <img   width="180"  alt="1-Cadastro de Eventos" src="https://github.com/user-attachments/assets/9a7b774b-8698-476b-9741-c13050a3aeff" />
  <img  width="180"  alt="2-Evento Cadastrado" src="https://github.com/user-attachments/assets/47db1c01-e5de-4184-9450-f4e3b567bd7b" />
</p>

## ✨ Funcionalidades

- **Cadastro Completo de Eventos**: Registro detalhado de informações do evento
- **Cálculo Automático de Custos**: Sistema inteligente que calcula o valor total baseado em:
  - Número de participantes
  - Custo por participante
  - Duração do evento (calculada automaticamente)
- **Seleção de Locais**: 8 opções de locais para eventos em São Paulo:
  - Centro de Convenções São Paulo
  - Hotel Grand Hyatt
  - Auditório Ibirapuera
  - Centro Cultural Banco do Brasil
  - Espaço de Eventos Villa Lobos
  - Teatro Municipal
  - Centro de Eventos Rebouças
  - Palácio das Convenções
- **Gestão de Participantes**: Controle de 1 até 1000 participantes
- **Seleção de Período**: Escolha de datas de início e término com validação
- **Resumo do Evento**: Visualização completa dos dados cadastrados
- **Interface Intuitiva**: Design responsivo e fácil navegação

## 🏗️ Estrutura do Projeto

```
MauiAppEventos/
├── Models/
│   └── Evento.cs                   # Modelo de dados do evento
├── Views/
│   ├── CadastroEvento.xaml        # Tela de cadastro
│   └── EventoCadastrado.xaml      # Resumo do evento
├── Resources/
│   ├── Fonts/                     # Fontes customizadas
│   ├── Images/                    # Imagens e ícones
│   └── Styles/                    # Estilos e cores
├── Platforms/                     # Código específico de plataforma
├── App.xaml                       # Configurações globais
└── MauiProgram.cs                # Configuração do app
```

## 🛠️ Tecnologias Utilizadas

- **.NET 9.0**
- **.NET MAUI** (Multi-platform App UI)
- **C#**
- **XAML**
- **Visual Studio 2022**

## 📱 Plataformas Suportadas

- ✅ Android (API 21+)
- ✅ iOS (15.0+)
- ✅ macOS Catalyst (15.0+)
- ✅ Windows (10.0.17763.0+)

## 💰 Cálculo de Custos

A fórmula utilizada para cálculo do custo total é:

```
Custo Total = Número de Participantes × Custo por Participante × Duração (em dias)
```

**Exemplo:**
- Participantes: 50
- Custo por participante: R$ 150,00
- Duração: 3 dias
- **Custo Total: R$ 22.500,00**

## 🚀 Como Executar

### Pré-requisitos

- Visual Studio 2022 (versão 17.14 ou superior)
- .NET 9.0 SDK
- Workload do .NET MAUI instalado

### Passos para Execução

1. **Clone o repositório**
```bash
git clone [url-do-repositorio]
```

2. **Abra o projeto**
```bash
cd MauiAppEventos
```

3. **Abra a solução no Visual Studio**
```bash
start MauiAppEventos.sln
```

4. **Selecione a plataforma de destino** (Android, iOS, Windows, etc.)

5. **Execute o projeto** (F5)

## 🎨 Design e Interface

O aplicativo utiliza um esquema de cores personalizado:
- **Cor Principal**: #23507a (Azul profundo)
- **Cor Secundária**: #cac7bb (Bege claro)
- **Fonte de Destaque**: Kalam

### 🌟 Destaques do Design

De acordo com o feedback do professor, o **design criado** foi o principal destaque do projeto:
- Interface visual moderna e profissional
- Combinação harmônica de cores (azul profundo e bege claro)
- Uso estratégico da fonte Kalam para criar identidade visual única
- Layout responsivo e bem estruturado com ScrollView
- Frames organizados para melhor legibilidade e hierarquia visual
- Contraste adequado para excelente experiência do usuário
- Design diferenciado que se destaca pela originalidade

## 📐 Características Técnicas

### Validações Implementadas

- ✅ Data de início não pode ser posterior à data de término
- ✅ Nome do evento obrigatório
- ✅ Número de participantes entre 1 e 1000
- ✅ Custo por participante deve ser numérico
- ✅ Seleção de local obrigatória

### Componentes Utilizados

- **Entry**: Para entrada de texto e valores
- **Stepper**: Controle preciso do número de participantes
- **Picker**: Seleção de local do evento
- **DatePicker**: Seleção de datas com formatação BR
- **Frame**: Organização visual do conteúdo
- **ScrollView**: Rolagem suave do conteúdo
- **Grid**: Layout responsivo de informações

### Navegação

O app utiliza NavigationPage para navegação entre telas:
- Navegação fluida com animações
- Stack de navegação gerenciado
- Botão de retorno automático

## 📊 Modelo de Dados

### Classe Evento

```csharp
public class Evento
{
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; }
    public double CustoPorParticipante { get; set; }
    
    // Propriedades calculadas
    public int Duracao { get; }           // Em dias
    public double CustoTotal { get; }     // Cálculo automático
}
```

## 🎯 Casos de Uso

### 1. Cadastrar Evento Corporativo
- Nome: "Treinamento Anual"
- Participantes: 100
- Local: Centro de Convenções São Paulo
- Custo: R$ 200,00 por pessoa
- Período: 5 dias
- **Resultado**: Custo total de R$ 100.000,00

### 2. Cadastrar Workshop
- Nome: "Workshop de Inovação"
- Participantes: 30
- Local: Centro Cultural Banco do Brasil
- Custo: R$ 150,00 por pessoa
- Período: 2 dias
- **Resultado**: Custo total de R$ 9.000,00




## 🎓 Aprendizados

Este projeto proporcionou experiência prática em:
- Desenvolvimento multiplataforma com .NET MAUI
- Criação de interfaces com XAML
- Data Binding e MVVM pattern
- Navegação entre páginas
- Validação de dados
- Propriedades calculadas em C#
- Formatação de valores monetários e datas
- Design de interfaces mobile diferenciadas


---

<div align="center">

**ETEC** - Escola Técnica Estadual  
Desenvolvimento de Sistemas II

---

**Desenvolvido com 💙 por Eduardo Ferreira Proença**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/eduardo-ferreira-39106b26a)
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/EduardoFProenca)
[![Gmail](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:eduardo.ferreira.proenca.brasil@gmail.com)

⭐ **Se este repositório foi útil, considere dar uma estrela!** ⭐

</div>

---
