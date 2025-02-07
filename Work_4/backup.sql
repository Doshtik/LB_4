PGDMP                      |            animeTitles    17.2    17.2 #    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    16929    animeTitles    DATABASE     �   CREATE DATABASE "animeTitles" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "animeTitles";
                     postgres    false            �            1259    16958    animeTitles    TABLE     �  CREATE TABLE public."animeTitles" (
    id integer NOT NULL,
    "idAnimeType" smallint NOT NULL,
    "IdGenre" smallint NOT NULL,
    "idUser" integer NOT NULL,
    "originalName" text NOT NULL,
    "titleName" text NOT NULL,
    "yearOfRealise" smallint,
    description text,
    poster text,
    "countOfSeries" smallint,
    duration smallint,
    "isComplete" boolean NOT NULL,
    studio text
);
 !   DROP TABLE public."animeTitles";
       public         heap r       postgres    false            �            1259    16957    animeTitles_id_seq    SEQUENCE     �   CREATE SEQUENCE public."animeTitles_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."animeTitles_id_seq";
       public               postgres    false    224            �           0    0    animeTitles_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."animeTitles_id_seq" OWNED BY public."animeTitles".id;
          public               postgres    false    223            �            1259    16931 
   animeTypes    TABLE     `   CREATE TABLE public."animeTypes" (
    id smallint NOT NULL,
    "animeOfType" text NOT NULL
);
     DROP TABLE public."animeTypes";
       public         heap r       postgres    false            �            1259    16930    animeTypes_id_seq    SEQUENCE     �   CREATE SEQUENCE public."animeTypes_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."animeTypes_id_seq";
       public               postgres    false    218            �           0    0    animeTypes_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."animeTypes_id_seq" OWNED BY public."animeTypes".id;
          public               postgres    false    217            �            1259    16940    genres    TABLE     X   CREATE TABLE public.genres (
    id smallint NOT NULL,
    "genreName" text NOT NULL
);
    DROP TABLE public.genres;
       public         heap r       postgres    false            �            1259    16939    genres_id_seq    SEQUENCE     �   CREATE SEQUENCE public.genres_id_seq
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.genres_id_seq;
       public               postgres    false    220            �           0    0    genres_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.genres_id_seq OWNED BY public.genres.id;
          public               postgres    false    219            �            1259    16949    users    TABLE     �   CREATE TABLE public.users (
    id integer NOT NULL,
    "firstName" text NOT NULL,
    "lastName" text NOT NULL,
    "dateOfRegistration" date NOT NULL
);
    DROP TABLE public.users;
       public         heap r       postgres    false            �            1259    16948    users_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public               postgres    false    222            �           0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public               postgres    false    221            3           2604    16961    animeTitles id    DEFAULT     t   ALTER TABLE ONLY public."animeTitles" ALTER COLUMN id SET DEFAULT nextval('public."animeTitles_id_seq"'::regclass);
 ?   ALTER TABLE public."animeTitles" ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    224    223    224            0           2604    16981    animeTypes id    DEFAULT     r   ALTER TABLE ONLY public."animeTypes" ALTER COLUMN id SET DEFAULT nextval('public."animeTypes_id_seq"'::regclass);
 >   ALTER TABLE public."animeTypes" ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    217    218    218            1           2604    16943 	   genres id    DEFAULT     f   ALTER TABLE ONLY public.genres ALTER COLUMN id SET DEFAULT nextval('public.genres_id_seq'::regclass);
 8   ALTER TABLE public.genres ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    220    219    220            2           2604    16952    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    221    222    222            �          0    16958    animeTitles 
   TABLE DATA           �   COPY public."animeTitles" (id, "idAnimeType", "IdGenre", "idUser", "originalName", "titleName", "yearOfRealise", description, poster, "countOfSeries", duration, "isComplete", studio) FROM stdin;
    public               postgres    false    224   ^'       �          0    16931 
   animeTypes 
   TABLE DATA           9   COPY public."animeTypes" (id, "animeOfType") FROM stdin;
    public               postgres    false    218   {'       �          0    16940    genres 
   TABLE DATA           1   COPY public.genres (id, "genreName") FROM stdin;
    public               postgres    false    220   �'       �          0    16949    users 
   TABLE DATA           R   COPY public.users (id, "firstName", "lastName", "dateOfRegistration") FROM stdin;
    public               postgres    false    222   �'       �           0    0    animeTitles_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."animeTitles_id_seq"', 1, false);
          public               postgres    false    223            �           0    0    animeTypes_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."animeTypes_id_seq"', 5, true);
          public               postgres    false    217            �           0    0    genres_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.genres_id_seq', 1, false);
          public               postgres    false    219            �           0    0    users_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.users_id_seq', 1, false);
          public               postgres    false    221            ;           2606    16965    animeTitles animeTitles_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT "animeTitles_pkey" PRIMARY KEY (id);
 J   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT "animeTitles_pkey";
       public                 postgres    false    224            5           2606    16983    animeTypes animeTypes_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."animeTypes"
    ADD CONSTRAINT "animeTypes_pkey" PRIMARY KEY (id);
 H   ALTER TABLE ONLY public."animeTypes" DROP CONSTRAINT "animeTypes_pkey";
       public                 postgres    false    218            7           2606    16947    genres genres_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.genres
    ADD CONSTRAINT genres_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.genres DROP CONSTRAINT genres_pkey;
       public                 postgres    false    220            9           2606    16956    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public                 postgres    false    222            <           2606    16971    animeTitles fk_titles_genres    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_genres FOREIGN KEY ("IdGenre") REFERENCES public.genres(id) NOT VALID;
 H   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_genres;
       public               postgres    false    4663    224    220            =           2606    16984    animeTitles fk_titles_types    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_types FOREIGN KEY ("idAnimeType") REFERENCES public."animeTypes"(id) NOT VALID;
 G   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_types;
       public               postgres    false    224    4661    218            >           2606    16976    animeTitles fk_titles_users    FK CONSTRAINT     �   ALTER TABLE ONLY public."animeTitles"
    ADD CONSTRAINT fk_titles_users FOREIGN KEY ("idUser") REFERENCES public.users(id) NOT VALID;
 G   ALTER TABLE ONLY public."animeTitles" DROP CONSTRAINT fk_titles_users;
       public               postgres    false    224    222    4665            �      x������ � �      �   D   x�3���s�2��s�2漰��/�\��e��p���֋@�vs�r^Xxa?P�ȉ���� '�)      �      x������ � �      �      x������ � �     