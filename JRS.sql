PGDMP     !    9                y            DadosJRS    13.3    13.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16441    DadosJRS    DATABASE     ^   CREATE DATABASE "DadosJRS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'en_US.UTF8';
    DROP DATABASE "DadosJRS";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   postgres    false    3                       0    0    SCHEMA public    ACL     ?   REVOKE ALL ON SCHEMA public FROM cloudsqladmin;
REVOKE ALL ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;
                   postgres    false    3            ?            1259    16477    clientes    TABLE     '  CREATE TABLE public.clientes (
    pedido numeric NOT NULL,
    nome character varying,
    descricao character varying,
    valor character varying,
    pagamento character varying,
    status character varying,
    entrada timestamp without time zone,
    saida timestamp without time zone
);
    DROP TABLE public.clientes;
       public         heap    postgres    false    3            ?            1259    16460    login    TABLE     q   CREATE TABLE public.login (
    id integer NOT NULL,
    login character varying,
    senha character varying
);
    DROP TABLE public.login;
       public         heap    postgres    false    3            ?            1259    16458    login_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.login_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.login_id_seq;
       public          postgres    false    3    201                       0    0    login_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.login_id_seq OWNED BY public.login.id;
          public          postgres    false    200                       2604    16463    login id    DEFAULT     d   ALTER TABLE ONLY public.login ALTER COLUMN id SET DEFAULT nextval('public.login_id_seq'::regclass);
 7   ALTER TABLE public.login ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    200    201    201                      0    16477    clientes 
   TABLE DATA           e   COPY public.clientes (pedido, nome, descricao, valor, pagamento, status, entrada, saida) FROM stdin;
    public          postgres    false    202   ?                 0    16460    login 
   TABLE DATA           1   COPY public.login (id, login, senha) FROM stdin;
    public          postgres    false    201                     0    0    login_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.login_id_seq', 2, true);
          public          postgres    false    200            ?           2606    16484    clientes clientes_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (pedido);
 @   ALTER TABLE ONLY public.clientes DROP CONSTRAINT clientes_pkey;
       public            postgres    false    202            ?           2606    16468    login login_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.login
    ADD CONSTRAINT login_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.login DROP CONSTRAINT login_pkey;
       public            postgres    false    201               |   x?e?1
?@??z?[X&???b?CH?N?p?4E??LÓ?????Oa????I?I>?a??&?e?e??x???^P???Zv?UL?@X???m??/??m{??G???|g???5?Co?q&         &   x?3??)ͬ?442615?2?t?M-*?σ	??qqq ??+     