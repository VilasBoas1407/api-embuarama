CREATE TABLE TB_EMPRESA (
	ID_EMPRESA INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_NOME_EMPRESA VARCHAR(200) NOT NULL,
	NR_CNPJ VARCHAR(14) NOT NULL,
	DS_NOME_RESPONSAVEL VARCHAR(100) NOT NULL,
	DS_EMAIL_EMPRESA VARCHAR(150) NOT NULL
)
GO

CREATE TABLE TB_USUARIO(
	ID_USUARIO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_NOME VARCHAR(150) NOT NULL,
	DS_EMAIL VARCHAR(150) NOT NULL,
	DS_LOGIN VARCHAR(100) NOT NULL,
	DS_SENHA VARCHAR(150) NOT NULL,
	NR_DDD INT NOT NULL,
	NR_TELEFONE INT NOT NULL,
	DS_FUNCAO VARCHAR(30) NOT NULL,
	FL_ADMINISTRADOR BIT NOT NULL,
	FL_REMEMBER BIT NOT NULL,
	ID_EMPRESA INT NOT NULL,
	FOREIGN KEY (ID_EMPRESA) REFERENCES TB_EMPRESA(ID_EMPRESA)
)
GO

CREATE TABLE TB_PREPARO_AGUA(
	ID_PREPARO_AGUA INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	VL_VOLUME_AGUA DECIMAL(10,2),
	VL_CLORO DECIMAL(10,2),
	VL_TEMP DECIMAL(10,2),
	VL_REL_AGUA_MALTE DECIMAL(10,2),
	VL_ULTRAFLO_RECOMENDADO DECIMAL(10,2),
	VL_ULTRAFLO_UTILIZADO DECIMAL(10,2),
	VL_MALTEZYN_UTILIZADO DECIMAL(10,2),
	VL_ACIDO_FOSFORICO DECIMAL(10,2),
	VL_ACIDO_LATICO DECIMAL(10,2),
	VL_SULFATO_CALCIO DECIMAL(10,2),
	VL_CLORETO_CALCIO DECIMAL(10,2),
	VL_PH DECIMAL(10,2)
)
GO

CREATE TABLE TB_TIPO_REPOUSO(
	ID_TIPO_REPOUSO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_TIPO_REPOUSO VARCHAR(50) NOT NULL
)
GO

CREATE TABLE TB_REPOUSO(
	ID_REPOUSO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_TIPO_REPOUSO INT NOT NULL,
	VL_TEMP DECIMAL(10,2),
	DT_HORA_INICIO DATETIME,
	DT_HORA_FIM DATETIME,
	FOREIGN KEY (ID_TIPO_REPOUSO) REFERENCES TB_TIPO_REPOUSO(ID_TIPO_REPOUSO)
)
GO

CREATE TABLE TB_SACARIFICACAO(
	ID_SACARIFICACAO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	VL_TEMP_SACARIFICACAO DECIMAL(10,2),
	DT_HORA_INICIO_SACARIFICACAO DATETIME,
	DT_HORA_FIM_SACARIFICACAO DATETIME,
	VL_TESTE_IODO_SACARIFICACAO VARCHAR(10)
)
GO

CREATE TABLE TB_RENDIMENTO_MOSTURA (
	ID_RENDIMENTO_MOSTURA INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	VL_EXTRATO_FINAL_MOSTURA DECIMAL(10,2),
	VL_DENSIDADE_MOSTURA DECIMAL(10,2),
	VL_EXTRATO_TEORICO_MOSTURA DECIMAL(10,2),
	VL_EXTRATO_REAL_MOSTURA DECIMAL(10,2),
	VL_RENDIMENTO_MOSTURA DECIMAL(10,2)
)
GO

CREATE TABLE TB_CLARIFICACAO(
	ID_CLARIFICACAO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	VL_CARGA_FILTRO DECIMAL(10,2),
	VL_VOLUME_LASTRO DECIMAL(10,2),
	VL_TEMPO_REPOUSO DECIMAL(10,2),
	HR_INICIO_CIRCULACAO DATETIME,
	HR_FINAL_CIRCULACAO DATETIME,
	VL_VOLUME_CLARIFICACAO DECIMAL(10,2),
	VL_EXTRATO DECIMAL(10,2),
	VL_ANALISE_SOLIDOS VARCHAR(10)
)
GO

CREATE TABLE TB_MOSTO_PRIMARIO(
	ID_MOSTO_PRIMARIO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	HR_INICIO_MOSTO DATETIME,
	HR_TERMINIO_MOSTO DATETIME,
	VL_VAZAO_MEDIA_REAL DECIMAL(10,2),
	VL_VAZAO_MEDIA_IDEAL DECIMAL(10,2)
)
GO

CREATE TABLE TB_TIPO_CERVEJA(
	ID_TIPO_CERVEJA INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_TIPO_CERVEJA VARCHAR(30) NOT NULL
)
GO

CREATE TABLE TB_TIPO_MALTE(
	ID_TIPO_MALTE INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_TIPO_MALTE VARCHAR(30),
	DS_LOTE VARCHAR(30)
)
GO

CREATE TABLE TB_BRASSAGEM(
	ID_BRASSAGEM INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_LOTE_PRODUCAO VARCHAR(20) NOT NULL,
	DT_BRASSAGEM DATETIME,
	NR_SEMANA_PRODUCAO_INICIO INT,
	NR_SEMANA_PRODUCAO_FIM INT, 
	DS_TANQUE VARCHAR(20),
	FL_UTILIZOU_SAIS BIT,
	FL_UTILIZOU_ENZIMAS BIT,
	DT_INICIO_MOAGEM DATETIME,
	DT_FIM_MOAGEM DATETIME,
	DS_ANALISE_MOAGEM VARCHAR(150),
	NR_DIST_ROLOS_MOAGEM DECIMAL(10,2),
	VL_RENDIMENTO_BRASSAGEM DECIMAL(10,2),
	VL_PERDA_EXTRATO DECIMAL(10,2),
	ID_PREPARO_AGUA INT,
	ID_USUARIO_RESPONSAVEL INT,
	ID_REPOUSO INT,
	ID_SACARIFICACAO INT,
	ID_RENDIMENTO_MOSTURA INT,
	ID_CLARIFICACAO INT,
	ID_MOSTO_PRIMARIO INT,
	ID_TIPO_CERVEJA INT,

	FOREIGN KEY (ID_PREPARO_AGUA) REFERENCES TB_PREPARO_AGUA(ID_PREPARO_AGUA),
	FOREIGN KEY (ID_USUARIO_RESPONSAVEL) REFERENCES TB_USUARIO(ID_USUARIO),
	FOREIGN KEY (ID_REPOUSO) REFERENCES TB_REPOUSO(ID_REPOUSO),
	FOREIGN KEY (ID_SACARIFICACAO) REFERENCES TB_SACARIFICACAO(ID_SACARIFICACAO),
	FOREIGN KEY (ID_RENDIMENTO_MOSTURA) REFERENCES TB_RENDIMENTO_MOSTURA(ID_RENDIMENTO_MOSTURA),
	FOREIGN KEY (ID_CLARIFICACAO) REFERENCES TB_CLARIFICACAO(ID_CLARIFICACAO),
	FOREIGN KEY (ID_MOSTO_PRIMARIO) REFERENCES TB_MOSTO_PRIMARIO(ID_MOSTO_PRIMARIO),
	FOREIGN KEY (ID_TIPO_CERVEJA) REFERENCES TB_TIPO_CERVEJA(ID_TIPO_CERVEJA),
)
GO

CREATE TABLE TB_MOAGEM(
	ID_MOAGEM INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_TIPO_MALTE INT NOT NULL,
	DS_QUANT_MALTE VARCHAR(10),
	DS_REND_MALTE VARCHAR(10),
	FOREIGN KEY (ID_TIPO_MALTE) REFERENCES TB_TIPO_MALTE(ID_TIPO_MALTE),
)
GO

CREATE TABLE TB_REGISTRO_LAVAGEM(
	ID_REGISTRO_LAVAGEM  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_BRASSAGEM INT NOT NULL,
	NR_LAVAGEM INT,
	VL_TEMP_AGUA DECIMAL(10,2),
	VL_VOLUME_AGUA DECIMAL(10,2),
	HR_INICIO_LAVAGEM DATETIME,
	HR_FIM_LAVAGEM DATETIME,
	VL_VOLUME_LAVAGEM DECIMAL(10,2),
	VL_EXTRATO_LAVAGEM DECIMAL(10,2),
	VL_VAZAO_MEDIA_IDEAL DECIMAL(10,2),
	VL_RAZAO_MEDIA_REAL DECIMAL(10,2),
	FOREIGN KEY (ID_BRASSAGEM) REFERENCES TB_BRASSAGEM(ID_BRASSAGEM),
)
GO

CREATE TABLE TB_CALDEIRA(
	ID_CALDEIRA INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	VL_VOLUME_CALDEIRA_CHEIA DECIMAL(10,2),
	VL_EXTRATO_CALDEIRA_CHEIO DECIMAL(10,2),
	VL_PH_INICIAL DECIMAL(10,2),
	VL_PH_FINAL DECIMAL(10,2),
	HR_INICIO_FERVURA DATETIME,
	HR_FINAL_FERVURA DATETIME,
	VL_TOTAL_FERVURA DECIMAL(10,2),
	VL_QUANT_ACUCAR DECIMAL(10,2),
	VL_TEOR_AMARGOR DECIMAL(10,2),
	VL_DOSAGEM_CLEARMAX DECIMAL(10,2),
	VL_DOSAGEM_WHIRFLOC DECIMAL(10,2),
	VL_RELACAO_DOSAGEM_WHIRFLOC DECIMAL(10,2),
	VL_DOSAGEM_SERVOMYCES DECIMAL(10,2),
	DS_ANALISE_FORMACAO_TRUB VARCHAR(2),
	VL_EXTRATO_APRONTE DECIMAL(10,2),
	VL_TAXA_EVAPORACAO DECIMAL(10,2),
	VL_PRESSAO_CALDEIRA DECIMAL(10,2),
	VL_TEMPO_CIRCULACAO DECIMAL(10,2),
	HR_INICIO_REPOUSO DATETIME,
	HR_FINAL_REPOUSO DATETIME
	)
GO


CREATE TABLE TB_TIPO_LUPULO(
	ID_TIPO_LUPULO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	DS_TIPO_LUPULO VARCHAR(50) NOT NULL
)
GO

CREATE TABLE TB_LUPULO(
	ID_LUPULO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_CALDEIRA INT NOT NULL,
	ID_TIPO_LUPULO INT NOT NULL,
	DS_LOTE VARCHAR(100),
	VL_QUANT DECIMAL(10,2),
	VL_RENDIMENTO DECIMAL(10,2),
	HR_DOSAGEM DATETIME,
	FOREIGN KEY (ID_CALDEIRA) REFERENCES TB_CALDEIRA(ID_CALDEIRA),
	FOREIGN KEY (ID_TIPO_LUPULO) REFERENCES TB_TIPO_LUPULO(ID_TIPO_LUPULO),
)
GO


ALTER TABLE TB_EMPRESA
ADD DS_TOKEN_EMPRESA VARCHAR(100) UNIQUE NOT NULL
GO


ALTER TABLE TB_USUARIO
ADD DS_TOKEN_EMPRESA VARCHAR(100) NOT NULL
GO