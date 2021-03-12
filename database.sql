PGDMP         7                 x        
   e-Projects    12.3    12.3 %    1           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            2           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            3           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            4           1262    16393 
   e-Projects    DATABASE     �   CREATE DATABASE "e-Projects" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE "e-Projects";
                postgres    false            �            1259    16433    projects    TABLE     n  CREATE TABLE public.projects (
    project_id integer NOT NULL,
    project_name character varying(255) NOT NULL,
    project_description text NOT NULL,
    deadline timestamp without time zone NOT NULL,
    grade_percentage character varying(4) NOT NULL,
    project_available boolean NOT NULL,
    subject_id integer NOT NULL,
    max_students integer NOT NULL
);
    DROP TABLE public.projects;
       public         heap    postgres    false            �            1259    16431    projects_project_id_seq    SEQUENCE     �   CREATE SEQUENCE public.projects_project_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.projects_project_id_seq;
       public          postgres    false    205            5           0    0    projects_project_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.projects_project_id_seq OWNED BY public.projects.project_id;
          public          postgres    false    204            �            1259    16528    subjects    TABLE     b   CREATE TABLE public.subjects (
    subject_id integer NOT NULL,
    subject_name text NOT NULL
);
    DROP TABLE public.subjects;
       public         heap    postgres    false            �            1259    16526    subjects_subject_id_seq    SEQUENCE     �   CREATE SEQUENCE public.subjects_subject_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.subjects_subject_id_seq;
       public          postgres    false    209            6           0    0    subjects_subject_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.subjects_subject_id_seq OWNED BY public.subjects.subject_id;
          public          postgres    false    208            �            1259    16508    teams    TABLE     �   CREATE TABLE public.teams (
    team_id integer NOT NULL,
    project_id integer NOT NULL,
    student_ids text NOT NULL,
    file bytea,
    file_uploaded boolean NOT NULL,
    grade integer,
    date_uploaded timestamp without time zone
);
    DROP TABLE public.teams;
       public         heap    postgres    false            �            1259    16506    teams_team_id_seq    SEQUENCE     �   CREATE SEQUENCE public.teams_team_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.teams_team_id_seq;
       public          postgres    false    207            7           0    0    teams_team_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.teams_team_id_seq OWNED BY public.teams.team_id;
          public          postgres    false    206            �            1259    16396    users    TABLE     8  CREATE TABLE public.users (
    user_id integer NOT NULL,
    student_registry_number character varying(10) NOT NULL,
    first_name character varying(255) NOT NULL,
    last_name character varying(255) NOT NULL,
    email character varying(255) NOT NULL,
    salt text NOT NULL,
    isadmin boolean NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    16394    users_user_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_user_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.users_user_id_seq;
       public          postgres    false    203            8           0    0    users_user_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.users_user_id_seq OWNED BY public.users.user_id;
          public          postgres    false    202            �
           2604    16436    projects project_id    DEFAULT     z   ALTER TABLE ONLY public.projects ALTER COLUMN project_id SET DEFAULT nextval('public.projects_project_id_seq'::regclass);
 B   ALTER TABLE public.projects ALTER COLUMN project_id DROP DEFAULT;
       public          postgres    false    205    204    205            �
           2604    16531    subjects subject_id    DEFAULT     z   ALTER TABLE ONLY public.subjects ALTER COLUMN subject_id SET DEFAULT nextval('public.subjects_subject_id_seq'::regclass);
 B   ALTER TABLE public.subjects ALTER COLUMN subject_id DROP DEFAULT;
       public          postgres    false    209    208    209            �
           2604    16511    teams team_id    DEFAULT     n   ALTER TABLE ONLY public.teams ALTER COLUMN team_id SET DEFAULT nextval('public.teams_team_id_seq'::regclass);
 <   ALTER TABLE public.teams ALTER COLUMN team_id DROP DEFAULT;
       public          postgres    false    206    207    207            �
           2604    16399    users user_id    DEFAULT     n   ALTER TABLE ONLY public.users ALTER COLUMN user_id SET DEFAULT nextval('public.users_user_id_seq'::regclass);
 <   ALTER TABLE public.users ALTER COLUMN user_id DROP DEFAULT;
       public          postgres    false    202    203    203            *          0    16433    projects 
   TABLE DATA           �   COPY public.projects (project_id, project_name, project_description, deadline, grade_percentage, project_available, subject_id, max_students) FROM stdin;
    public          postgres    false    205   +       .          0    16528    subjects 
   TABLE DATA           <   COPY public.subjects (subject_id, subject_name) FROM stdin;
    public          postgres    false    209   �,       ,          0    16508    teams 
   TABLE DATA           l   COPY public.teams (team_id, project_id, student_ids, file, file_uploaded, grade, date_uploaded) FROM stdin;
    public          postgres    false    207   -       (          0    16396    users 
   TABLE DATA           n   COPY public.users (user_id, student_registry_number, first_name, last_name, email, salt, isadmin) FROM stdin;
    public          postgres    false    203   ��       9           0    0    projects_project_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.projects_project_id_seq', 6, true);
          public          postgres    false    204            :           0    0    subjects_subject_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.subjects_subject_id_seq', 3, true);
          public          postgres    false    208            ;           0    0    teams_team_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.teams_team_id_seq', 1, false);
          public          postgres    false    206            <           0    0    users_user_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.users_user_id_seq', 2, true);
          public          postgres    false    202            �
           2606    16441    projects projects_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.projects
    ADD CONSTRAINT projects_pkey PRIMARY KEY (project_id);
 @   ALTER TABLE ONLY public.projects DROP CONSTRAINT projects_pkey;
       public            postgres    false    205            �
           2606    16536    subjects subjects_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.subjects
    ADD CONSTRAINT subjects_pkey PRIMARY KEY (subject_id);
 @   ALTER TABLE ONLY public.subjects DROP CONSTRAINT subjects_pkey;
       public            postgres    false    209            �
           2606    16516    teams teams_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.teams
    ADD CONSTRAINT teams_pkey PRIMARY KEY (project_id, student_ids);
 :   ALTER TABLE ONLY public.teams DROP CONSTRAINT teams_pkey;
       public            postgres    false    207    207            �
           2606    16518    teams teams_team_id_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.teams
    ADD CONSTRAINT teams_team_id_key UNIQUE (team_id);
 A   ALTER TABLE ONLY public.teams DROP CONSTRAINT teams_team_id_key;
       public            postgres    false    207            �
           2606    16408    users users_email_key 
   CONSTRAINT     Q   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_email_key UNIQUE (email);
 ?   ALTER TABLE ONLY public.users DROP CONSTRAINT users_email_key;
       public            postgres    false    203            �
           2606    16404    users users_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    203            �
           2606    16406 '   users users_student_registry_number_key 
   CONSTRAINT     u   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_student_registry_number_key UNIQUE (student_registry_number);
 Q   ALTER TABLE ONLY public.users DROP CONSTRAINT users_student_registry_number_key;
       public            postgres    false    203            �
           2606    16537    projects subjects_subject_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.projects
    ADD CONSTRAINT subjects_subject_id FOREIGN KEY (subject_id) REFERENCES public.subjects(subject_id);
 F   ALTER TABLE ONLY public.projects DROP CONSTRAINT subjects_subject_id;
       public          postgres    false    209    2726    205            �
           2606    16519    teams teams_project_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.teams
    ADD CONSTRAINT teams_project_id_fkey FOREIGN KEY (project_id) REFERENCES public.projects(project_id);
 E   ALTER TABLE ONLY public.teams DROP CONSTRAINT teams_project_id_fkey;
       public          postgres    false    2720    205    207            *   �  x����JQ��w��n\&ܙ$\���gd�QiZb*t���v�
S�`�M%ѕ�D�Dü�^���Q#���Tf��{�f�w��+D8�����G\��ǀ��g�b��>��F�q�%F�.i
Ox1s�H�
����|�b��a��.���'#���p'Ը�� �TZҦvO��]=�D�cV&�0okq-�l~��c��fY��d̋�)hc�ܫ�fAՔ�r^�,��s�Ƭ�d�5�1Ә2�أ��I��.(a���Ϥ#�Tr.S� ��|���c�q9�#�8��qt5S=����{nj�_�r#m����l���Ƕ�ej��������ٛƥEpg	{o��͔����/�	�[��j��Y���p{��Uy]�Բo76���7�0P��W�^q�(�����M|M��9�S-b��~���6n;�v&�6-Jm��e���������L�WG�S�W�_$|[��d�]��Q�>�u��HV����7��f      .   p   x�-N�� ��`u�:!��u��dy�4��q�����q'�H�n����#b!*-;1G�2��T~��xK)0�0礌�=x�Ԗq%��Y�B�����W�ND~p�n�      ,      x�|�K�-��m�ۥp� �n.���-��{g:��|�ޱ��k���B�O��������w����)��������?J�[��[k�����I�y������<+>1�f�9g�����$���Gs,����S��}/���������og�ÿ���+�e����_j+Ǵ�Y��Ǐ��ٿ���|Sn�7���+%Ԝ�����ǻ�n��~�(��j�O��/���gı��{N5�3�:#�36�Zqξ�*��]#�Bi�i{�c�߼j?����䉞Ծ����e�<��~x������^��+���T�o�3�o���<�t�޾�����PB���[sI��|�j�S{X+�P-�����u�@�C<sf6r�g�la�w��H<_��|V9�ySM_��),�"����ͣ����o�5��Ka��
��^'&>1�̲�ǜ)�}�����-�ghm�]��1������9·�K5�'�6w��5c�Y�^N�b��Z�|=��f~�鵌_��ed�ߗW�_���x�R����k�0O:�`Z�k����o�7�:��O̱���ؾ<�yS~v�e��Vby1�V��B��V�����V�L�İ�˾�������-c��ߙ�f��7gAG-������^o�)_eA��N��V��}�c��>��z*i��JOm���%����~{�������c��WNg�o���g{���ecW)�������_���{���K�o�C��]��SS����G����q>֩cEΗ�S>�����^\`�e��'3���\�Q��|�}�����8~:?X�g����?����ux��=�I�d(l�1����֏�(-L1�����y��w�����C�)�Gڋ'�+�}����1���a��>P ��9��ux�#H��=|�x-�i�emuק�^5��k|&�%u|!�ȕ��=��s�x���{��S p�P���^�|_��}����ߖrڸ՚_�5�¾�/����O��:�nU���<�5�8Y�6j���zӞ��X�U�?�	����^�S.,z� rl5��Cgmy�9 &��
��U��,� �/�3��:&� \d�O;�1��4��zW����./�	x��(P�&?O�÷�U|�%�}3y�����;ٟ:�-X*!
�*)W����<)�DL)���'�?����J��6��NS���E@Iq~,�8�8�0��]�%~#�����@�{���.	�i��2v`�S�	}��F�+��9�_a�;x�m�� ){8�e��a�y�2��!t��W���[�`������{�"�m�@��e�&߻@��2(	�W�z�(��<_@���Y�wƍ��|��?_a5�9�c�#+��Á#�~�f������i��w�g�c��+^1��3�d��=K p���gb��WϘ6\��
��3�_��7�y���<��������a���?["
��n{];`�i���n��ayƳ*��<��1�7���UV�-��7�Sp�B%2@0p��NV��G�|ǎhЅq�?h��%e_ݕRY�h��gb,Ohls2c�������j�����v"˝
�H`�z>��p��Yc�3Fx�lֳzf&�Ku�����f�:!	)g6�6�I(l���J�n��=�"�O�0��m?D�6pd�}�<��������� ��Nz��Ѡ9��f�҈R[�$�i�!c?}c�w_��!��y~	A+�7^�Vm����;��ak�$b��`��@�2�]�>��0
���sA,Z}-H�yM��H�bBC�֜�]�up�r2O`���l��V��e��j��M�$;�����"(c�P���xDm&���6~�`@llQS��o8 �y���iP��|���.4A������D�e��
��)��WZ���UX'k//�oƂ�G�����A��_CGS�A8��7��fM�~^�S��rh���y��%�v���زy��H�:���"�o��zd%�ax��}��>sǍۀYC��}�0��#�%D���1	�|}Ǹ�k�ZHq@g�rf�����[��N�V��f ?pL�S�}�;���}Re����+�"����
?�ev�����?/@P���C�w��؍��4�]`́����4��F4�����#��B�	S�1:�V���y�6�� 0�j�>fV�m>a~�g^���J����=�����9��/1��z��	��'��
<!!ye ��y���ܼŝY���]��~#��d������x�oH����o�ވ�/Z"���+aU���#� �H����,�W~��\7�%�A ë��w����'ڶ���@��ㄶ�+d�#����L"�u&/�[�&���Qh�Kx�L |��J�% ,����@�&������RU��&�`}��I8���k��X%m�W����ٱ��|�˯C��}�a!�AD�w��KK�(��	Sp�}� b��Є ,�x)��j�@��ց
^����u�^A�"z a��Bh��5&#m��a��`͉茖D�h������$c����c��Ѧ�����%A ��
��OON00vb�k� �͏C���#N2�.�
�e_���҈bw�b4s!��-�@	��M� �#Ī��e�d�_8~b�(�N�)��ו=��P=��K �I�O�3��w���A�6��V�F8LC���'��<�l��#�`ְ�W.� N�a�\Ū���!Nr�<}��
���q>�P��`'$ FtbyES6�ϫl-�W~
$S�|�a'�U�t��<|8����~
<�4@XT~�����U����q���43��5O�Pp� ���	��'�:���`�a6���ЖA(#�`�[P�QDj�8jh�5�D�4s�
���
����@S��c�Ⱥ���q��0]_�ༀtـ�m`����G&,;�a]y�7����G]�|�M`Mh��[$�;���h�����DK�cR4Q���1�
l���'�-^�Y��5���v�ؼ;q���Ӣ��Ā�50cg]_��p \"Ȅ`��ֺ��!�/PY�~�@/{�E�ָ�9���: �x-�����؟Y7V�m��^�6���aE��,�0�fm+��'��)Da�/(�������4�HL̄�? 0�(�Kg�C���B*��9�S�	����Fj�u�������(Q�%ARL}g���t"�d�l|2��#VeI�٦��-8���A�Dl��G>r�#����!mi���Z����S�.$�� o0H���A4g��o��Ó�BF:�@�� �[����� �ظ8�x8����9���=Q�p��Ӯ<�ٞ���vx����}��I!%��>.�ڍ�XQH<��xԂ�avWǄ�ks�"�W�j���\��+e$.}���7HD�Ă	�N��_�~Є
X�����b^y��^�������t/�ۄ���i��x⋑�/�#�htx�|�Q��ISV�+>|ZU���h7�/�Y�)ï�i�F/���R<�~s(���OG��H�h�u�g�?��a�	H8�r��M	��}�P�2=�`X'%P�����u��aY,ז`'�1��60f�s"�	`��/�l+��L��'Bq ����N���8������� f�!�o�g38� Ķ�s<2�a��6��(1<����x9��Sݱ8��V��UC��(�&@�O+~ۓ#f��)i^�]���cY5�;/���A�<DQF�M��%j���8P�=�M �Еcc���lf�O(P��� ī�OЄ��,��?U�4�ɨ%��r �f ��p�&�����k��@��ib@�T�'t���r K5UW����=�WFBEIy1�<e����F�� Ѓ�-�@���9�_�d�@���aV�w��ϙ���;�b�������,���l�����@����    ��T��9��L+������Ͽ��pn��EZ���m��O@�m��hF����+�}QS����s�
^���H�����F��{�lҏ|�J�*Q�1+���\���\�ab��+�ٟ�]��g���3���������ŗ"�QjD��A3`i/L�È�Q�FH��j7�!�Z��`P��UbDsT�17�u �5���6�',�n���T�%*�\��Y"j���G7�������k��P1XD3�F�,�9��� @�[���pN���}w��j�l�D\�Z�>d�%(4$@� �D��'-�Պ��b���q1&�JOO���A8d�9�J8��EiR���]&��8��_;����`����o 8p7\�0D����� 6J��`3��/�",���G���X��/����,�Y��<=('T���fb� cw��vW��+c��1��ˇg}�@�?�� �M�/4*x���,����e6i`������2��`~>B�����|l�O�s�~�f"6�%E�Q��1џ̺�"��[��ZO��oa�=��bd�,��&���X��c�𩭄���8�d����@B�~�A;#(<��<>�/�,�|n�>m��ꑎ�SD����<�*���V (����6y�J��aa��K��5���T� ����������0o��a9M3���և[A�K�3�J��O��h�ߌ�@5��*����I̎��a���A���2�M�������=��4��[D���Ag�:�kfUg�]��"Qb��2P�"
l�.S�#���^A�����X:P;!����B缞�׈=��0cӬ�bw�I��C����AB�k�`�dW��G@�6-ϭ�/VA� K��U�3�<񹜐04k��"�x��� ���fT�+��0���n@h�i$��[���c��������,��?��Jաq/�U��'Z�P�� _�ដ�CE���W�Ӓ�x����A�<<I(�/����~	؞�!{v\t�v�Ƅ"ϕ����)�� -�3��XQ���Je��s�0�"�Э� ^�����[�����OO)l6�X!*�a�:<{~{�s��L�Z^� B�Ɲ���U�?D���:�ݮ�(x�g1�B��$�\ّ:�Ӵ�c����3�Z��>���.�a=�V0_���e��`B�qE9���##�l��Y0A!���x�����ɳ�0Qko�h��6�W��U������̗�`���g�L�E(F|�O$�����J��gaP���S�-�;�5,lfM�6�� D��=� �ô+{m������O�J�A+t��75��b+gLXD���2��5�p!=�3��2�U.|������	������A�ag<a��� �Aw	_�R6$���Y܁���;��N`tX|\pyx٧�%Rc��B�F�+����z����Rˣ�1�P�$j��|͋:��P���<�Z�"VK	����?0�xX)"LG.$8�r�d���O��% 	�?N�PC�:�,a2�$��Y���}�r`%T���|4�+A���wk]�m9Qx�Y��v��<���2��Zu������ϐ=��	�Z���fD�� ��$�=.e	RM	ч"Ţ�������9�(���V
Ļ�,ŗ>l 8 �Ozv�/1��/����dqB#��I�kv/A���<�>&;m�h8V;$��y���tI P�{�O�/8+�����*K�ݷ�6�7�0=�FW��=G�i�<Q�z�ZQP��f!�X�'�6K�bW�-d�o6+�5�f7���?9u"1*��"�a�3�/x�35=�M��Ȕ��x�Ft����,�1�
���1�ZN��)BZD��cm�aw��`w�9�f&�4��Ӣ�ܘ��ڥ��&�����;�B8�Ey�C�3����G̫w�6���>,t����͔B�Q���3�
�1����(���f�W(�2 d��O�
�Ub�p�|�x��H������+#�l���L�=I�Cd+D�j�Q�<$ļ7�Ѓ5��)�J�Re����JS��%��d����}�c�ZP�0�?;o�ͯ*³�yH`s7,���P��E�"Bu�u@3��4��X�F�;���W�)!X��&��	
��r�����#̀2�҂�v��D2�H���8=�F	{����kC�>^^���y����䏱�Ȍ婬�<V}l,eI�2�Q�/�����%��_ ����A���ʭF��YG"�{z�v D��Hs��굲�eI�����z�y4'��	q'O�=��o��h�
�\��b��.��S
�%XD6LF���z� v�p�߰ڊ�����ؐM��%v���R&����Gy+���iqi��� _'�f;Թ�qa�o �A5�P׮�|q`��8���� �I`݋p_�QcgM�v *�L����mq<�m^��bEo��`�`����,KG���NmI�m�l+��N���b�䰶,n�Ϳ�
�k���AJ�t�����H��a�`��; ���+xE�ǁVMA�^����[:.��;Ym ��s-�L7�KO8��(��{�;A��VE���``|�g�����#h�����Of)������&�?�Gt��y������~����Ag�2�2���� ��R,�3�M�
I��ʏ��@,���a��	p���V4�s[{�<��> �������D��Jf%_�&�mk~��쨒��-�b$�ܤZ���nR��X1͞{X�d@���֘����-�����R��������(YU������y(�_]Wba��gE�~�((̤�˪VV_J�LT~{��4n4,���.�	�	��}��A=Ho�d�t��pU��C=�9�_�ZhʴZ�Q�p��C���+V���/���H���z�g@?��49��9��P��N����3��e���/��'����FsTp��� �q�3O%rÝQ�f���j����j#�!,�х��ǪLT�M��o����7�kU �1.w5�U��w@[>�ʏG��
�"�F�rx+����:u�z�[��'8(��G��V{�����8��E�FO����~����\�D�C����lL�*BT6��:���'�!���Y��	�)̳b��@$ i=#�,w2!?<<���p�{������/�w
���ұ���D�i�T�F�f-�%8!�Y���W"aY��}Fz��tн�y��pk"���e����wXUA- �恰w�,����yh\�h����l�S�����
� �XkQ�U���/;4k�6!�@8����C��6�2Q�&�7=��3-y�D�m%�G>�,b��2	!��y�1����<��o lY'�	{&"F��O�@��j2�	��X�w�B��ٰ�ʮ	�P�yW@��U�u��3h��4 ���k�P\�$�D�e�d���A6��8O��CTڋ&����]��Z���e� ���S!�O�O :sn��F�j���cL^ٺ��� �k�]{�C	�<&'�yq��b�׶HQG�rʸbW��}�<��@�'�f�T�Q*f�8&ޞϼx�Ef�<�W����/'��� O��Ӑ[h��o<Z`[7��GA��@<�_=���"�`y�-��P�Lq �AW���o_�����e�Ps��!��y˺���H�!-��/�,S�_7�M��Y��B�5!����#�wP��y�ŝ	���r$��!�n��L�6g1��Gd��;��07ď+8����@gZq��=� ��k�v�e�N �L��>�9d	b�#��@�԰����$��z�MUP����v�	^�6���У����Y��A$L�@�@�r��J7�AƂ{ FV�b�f���~�}y���A͉��B�ˏerc�	��v<������"�Sj�Ժ��J�႟G��a��	)�.���&װ���{/�'W/ d�s���    )|�Lu0)��)����x�d���$vn
`	z�yT_�g^��Mԑz�J|x���a[S\�@жT��g�#�nΌ�%t �Q�`�T���^�K&ԙ�r��N���PY�r{D����<�]�|�+��jg݂�Lϖ��_i�-�n��-/8 ����A��B5؏"ر�G���Z����4�,"
ܽ�	�QL�p�`�9�c�ZG��A���ڇr+�7�Ua=`��E�>��0&�ر��9M��m��O�+�2�����|
��k�o���9��.�熌a���r|~L(yy�=�0P�_�J���L�$����4��b��B	�dW{��Ϭ=�����߾�ea��u��:,8��c(8L�v�LD���� O�岉Oî�:6O��V�T��1�54U�=\��]����X<�E���o����DHw��A����� �[r�41�����\�%$e�(��h=��m�FQ~�U{�p�<�#a�8����b
�u抖�QnA+$���h�Bz�W�=~"B@�-�h��Z���gDͪɑ<��)�L�Ō��y����0	A��	��k��:N��\l��iL��J��(����C����I�h�[��}�O#���e�����n��;���SClCݗ�}��KT�%��0tO-�N��F�hN���R������4�Bx�����J��F����
ޡZ�0?�E �����	�ZHt�u�e<��p����TP� �R�Z�����p��T�۔i��P�e��ك4j��رB���y�g�B�����ښiw-�墡�����L�� `�܃]��}�5,+X�t�i��-���g�Nj��D!�c=�N� ������X��/-�chB��S�%P�X�� @ey`�=p��U�B�͗P�,}nX�r��y�ҭm����5�'�_�`�@4j�0���;�,s�[ ���l�=ۇXܺ�D��-pL\�P�k^�|���+��p(�+�lgo�hc-^���Q�5���.auOAeW\����J� ���C��Hƨ��yzvF�m
��P��D^0+ğ� ��Hf_��_^�p��ؽ�=���e�a��O�ğ�S1[�J����;LB� ||�n�jZ��3J�����ђ6 C�S�B@�Q��%V>p��6"�͋b�(ٍ�#�����P��&�n���%:lh�f<��@����Bԭ5�`YD+�g%��( 	�蔑��ٰ'��n�
�j�`>"���Ğ���f�[����dm$�F>B��J/��x�^=԰W���u��zp�B8�|���ӺE��&�fcS�i�6|�a�0�ߡ�p��;��6P��y�C���M�/�qަ�>�Y��k!����V�H����c���m�a�G�L�a4m������a���;U$�T�(�6��UL��oX��힄LX��载�ϕ7�L{Al���y�cN� S,��G�� ��P�Ro�1�Ed:��y� h�;�m����ʔ%��'��L�!4� ��EC����5-�P,e���ϓ<՚B�{&��;!p��K���|01 h��:�ΨkU<���x�	lq�z�Sr�!	2��n��AC1��~$7[ ��11$���f�Z������3�}lgg�0<P���:T��"Fa�̍��',.�q,(<H�ߊ���^>@���F|��S��[,�1h��@�:v�᎞̱9�a��,;�ʏ?�g��[�]��"������:�/�����
^���P)�4������o	�C� ;i��/�������(���rxN�m\~��d"���� ;�X�3#�����UÊ��P3�����^��{n8��ڣ4��;�ͺ/���	7Ƅ��0�}ي��}5��Ǯ̒�T�uB!r�Y���}/^�����EA��+Gx��I.n�-��R�:K���[p0����)��}�.���J�E���|v���Vţ=������X�U��b<���[����[�����w�����-x���g��K���,جMm�/1�[ ��mɩ��	.�c��s��FцH�M�Q H]s�>"��m�d�-���B�d6O \ce�l�!�@'���F�a�ǆ?m���}���!>2[�T��%R WM��Yے���'�d�wcɒ�t��U��K�ׄ�zj4H���Xq�" =�F)�a����s��R�=1~��c
����ۆI[���|0�����sz�m<�[���,|Ԅ��lAuZ.ö�t��D?z��K�5XF�Xp��я����|�xϨ_| ���>�=Rچy�a���p{$�x������{w�OˁXR�Q��������K������g�[k��;o�Ue1��9<k����p)����
��.6�#����Dه�	�����oB�s���n�~@�?�)�u�6�����2����a�Hdŋ���qc��{L���hs�Q����2k{c��"���}`h1^"Zd��P"����2� Z��讏�����0��J�*���P�M`�١Lu��%ĝdB�2k[��=�<'
�jٷ���ƙZIb�-�?v�l���m�@��7��M���Ţ��Dw|>�P3o����L{�+�Rpk����Հh	(��>:``��Q���s,�x�h��H�����$��G���%Dy�Q@ �f~͒�nꨚ=A�L�$���G^�%]������?�d����s�=�0ډH�1�c+I_s<{ǩvrlP�!�ghv5D|j)�f���D��U�Kӹͺ�����FrD������D��D��'�M�J�~���z̷��Kp�v�jU�X��k!$��R�#{ ��`(�9g0��%�|��0Cy�P,��$�'g�����e�]��Z���B9��2n�O��ﱇu��/�}�%�qo��r�1��k�������d��d[PV?:�
3�� �֐��B��Z�ۏT��~<M��\��y�,�ީ��ÀiH�D\�s��a1��WQx��veT�����1���O�[��k�vZ.�1�)<K��� ��Ax�=��E ؞�aTP�z���_O�A%@�-�eFv��f�ڋ�H*+��@���W�ڂ%�xƀ�`��+8�ľ��4��W�d���A\Ż�U����vj�%���ztf1M���,��V�ݹ2� ��*��:
���5����Y�}k}��oY������[�:l\�[

9 o	p��UI��iZہ�(ĝO+v>�v�����Ԥ�����8{0�b1��A`�>uݶn���D<�f�_f�+�b��5��_�(dk,{��ǋКP�ML�����~-lf�����ON �Y��v���Y#.�gi��jI��&���e�I���8�",9�Ǳ3�~�V���\��C�Bv&�>kW�1�X��}�EG����c��ա�=Vo;�.-��	E}��sï���m5���T�Q	�nsU7��J�����_��[d朞i�=��U,����iQ~�" [c��U�~�<[E�O���Qx&��+ WԈ��Z��D;B��O���3���U�%} B�6@�|�N��Hf��f�=�5��L�Z�k<�� �XI
�n�Ѫ-�T��6J�Yf��D^��5@�<}�����t�gdݰ��P�a�k�����\�>���C"A�.D!�w��h!{�ά�NfIo�8��Uo�~z���ŜX(B�GHf�]O3���@��`=�����`e�v��S�lyf�������+�ˏE)���eZH�OC���霨쉡�*lA��]�8����6V���}��xԕ�"a�T�)#۹7&K�pX�g�Ӷ*�T!���@-��Ϟ�W!���kK�qhl2����r��n�)��̶ҹyV���۝��ޠ�=8����h����;�U���NIA~۾Y~l n�;��u�?U����� L?8��b)؞%��V�W-O��a	V*��Imv)&& �B������8},['jr�h    {V��d�S�2����yt����l�=�~c����ɣ�oe4!7��&9�%�3RQ#�������LBa�x��EW���gڎyL�����k�vǒ��bQ�1��k[g�*V�������i�o֍�������@�{Sp#JΊ �`M6Z���juv��3gଷz����Q�0�ɖ ypi�?⟝�f~d�VT�#�̷1�èow�x�()OQ]e�4�@����c�.�Q�7��N�6a|{{�]07ؑ*v�.��~�#��L��`���K�a�N+�Ex� ��s���bS��ǒk�;�ju�b�NiJ�o��|�,?�;���n/�-��p+"�O�}�ϙ#BӊSU���t��Ӄ^˟�AW(4JDI�P}��#%m|�`�#:���E�Jg��= B�;�͉��<��t���eϞ��ɞ=G�2͉,�&)XQ+f�QU�O��!_�ЧŚ�qg�<��;��@�IP�45i�-=�0�T> _Zd�}V���X�~u��ێ�������)���.&=@w��zeYRS��9%�ԇ��l0����B�4��$m6��ul�����#�0@ d)Wl��&Z�$�m�+���#>�0������b{�-g�4χ�İP��`��~}����~���L�!���e�U4I!��湼�~�/A!�"�x��Av:�-Ϙ�GY�q��j�>T9\Äg� ���O�	ؗ([?O� �oԭRe���5p����sq��7>�އ�ۋm5� ��N��Ǫ8.���8|�I��3�����;�Q�`�Q�@2<z���x,+ট���Y�/]z��L�ӗ_gM~N��0?���6���3K"VV�hp٫�N�$�YG�7�%�)��d9�h'�	̞�q\-�A`����H˙H�zf�`�(��򛀿U>}?3@�?����(3y�l��qv�حj�,d+�sXb�&����0�TiZ=�X��Q�({4��z�7����< ��H>�Ȭ���^��+��|�l�����F���x���f���_�J�6������jL���Y'��ى�_�ͻ+0DD�cXC�B�&/ ˶Vg�<rP�ݸE/9���V��'�s����|0�53��*��B���+U�\@$�A����0p1�9��v��������ާ��$KV��ԅ1�+.��S�)����3J�{[��t�ڦ���b�&� ���F+�=;Ev?���t��iw A�oU��E:���$OE�E��<����2��ج���,��#31%��_y�(l
w]t*��V�#l��a�E����V����F{{� ���|6��au�-���;LVv�
0�(�U{��T���(P���f�l�5�����%O�-�������2 IP�M��0-1��e�/���do��t?Bz���lvr��1Q2��t�ρ�8�g�[ ,�kw��ؒ�{o��6dm!�F%{#J%J����A�1�)��##Z��]����,��t��'�>�� t�6���s�$��ȉ�
`�p0�����j��E�Ŧ��(����4����Hb�v�ꝍ��{����#x�r��?�Y�PT��3��Ì)���y�d��!��P| 8_�m���Fl�bxz��v<���i<��U {L�=�< �`S��Q��p&Tas�����1��Y��)�3#���׉�{ڦt��G?��뵌��tS��[-Oɷ+'���Qgz'|�8�z�Kk�o�ZwΑu5��0T-�X��In���N�4y`�8Jީе�񌹨����Y�mȧ��3m^p�	Ƞ^E���);�O�8���դ���`"� ��e_��θ������i�D��؊����}���	�ܠ�����8�������'���2�OJ�(��)��ְ6y�S�M	�~������:���.�.qk��qe{o�.ě�� �y{�o�UWR�ސהqx�6L�AzD����l���SV����Fg�����]*�?�;W>�N�e�q�w��YMf*ʹ@���n�ԉ&V�B�2�޸b-���K�0N��XX&�a�1:�VGZl����[|�����Nc[��;����q�	Y��ֿ|�&���(	t*�E�qˮ���� c
q�y�gH)J�r�JN�?|�6lG����T�=��&��!�X)��;5�(��#p�y���	Y�x���́�=Q~���eZ�1���w��`�D�|NU��;�H��y�lT��)Ȑ����f]��j�GM	��#b�Ć��D��I�ڐB7�F�4�[ove���)�,PF~؈|�Uk<�|K-xeDڹ$gu�沒�b�<�$4}t�j��o�Z=w�`s�GCwK���%�y�$�e��ih�ȧ�������7���_L�j�Sz�X����Es�jAsk9���v���M=��Txᝀ̖FX�������)��Mw@���6��ǈq���ɱ�`���#C� ��P ���9:�͉'�S�κ�^�N�Phh�L��N�U<���G�;�Q���ϾU)-����u�[h�906nC���bKt���p�<6W���:"d|6w����Z/�k���H��X�
	Ǭ���9S�䛽:�+���H3{{�y�������<��#۔{ٍfQ��D�R��$�f�T#��mʂ�K�1U�u8hq^l�.2sB�׆�D�'�D2�&E�J�sk�(FE� X��QC��	vl�=^��JH�� �9�VS.N+���y�L�����ǁ��i��[8qG=g�H�͡X�Q��X��"4*\�>"���{?���w�˝�X�xg�<D"���zg��m�pv��ym?Z0V~=��[bH�����#���fz���l�}=fʳ���)3Μ�w!���`9w������E��'��ˠ7���8���(��wPڄ��'��O����x/I���z'����ҝ�P,`�EM,c�Wj�ԝ��<Po`��9�9�=7so�wctg��Lu�zk���#�@{ʊ�����ͷ��=�O�Tȓ��	bο���qx[�^͊c��w~T��.�ȃ-��&&�$t94t�Ê,B�MKx�# ��v\��.n���D���g��#�3��qq�{B���i˛�#g.&��~6E�������!8 �3�j~d8���N�M�^��:A�	�;,v��.����X���/� '��n�+�ڗ�<�rق�u�%+���g�����*��
�4,�r"mw�#��~v�]c�k�S�2�ˮ��y�z��=�%�ڏGo�A�w�'ɓ~���n*��x�5���e@����S%^ �lOd�
��'����6���MṏR��c82ٿ����.)��H���t��m-��H����LW ��C0��0�^����?��-��w���
�."Ѱw!�(n1\k���*���󭸭v�A�=Q���dUX�R��ٚ��U�CgH|ۢ�[&�x//q�9�v6���jN0tL��dj�.b�8#���[\�ygo�@���	]g89�N��o�۸�Q��#>��v�%$�~u�y�,�e7?2�.�m����r�����a�|�˛%�F�(��)��l3h�b��F��卩Y�.z�+�ތ�q����*|��6l�g?':]�9�?!~͈���;��j}���w��pl|���#�h�b��;�΃}-��6��:�=���	V���v|CwZx�3H	� #��6��@k��X�mA[S��v!m�L��=Ns���;S�;H�qL���,.wjβ�g����Oh�vNB�k3�}���;��Q�ϴ��:C
3�c瓡�!S0��[y�_i��*�z'�>�c�lu'~7�@
s ���3�(S8r�p�B�Pl�o�W��&K8^^Q���7=�kļLg�ˬ*b���b@*�=r1���<Ͻ�
���������t緖��7�.JU��T��'V��K����.���ظi��SON���鴵���u@|p �9��K@'仜ae4��\�]E�@�Y�o�\v�=Ùh�$oN��;��    L��L�u�g�c@�%\jW̵E�H ��7?�?�mW���	�Ep�ľ��������uK����e�{�\���8:<AX�Jf�X ��@��tB2x�#>�˂%z�U����18�ع���۬Eʗ� �Bw�^�V�ㆇ߱�6����9mȒ�GT>�ws���=�|=�3hNS}I�hj�*�"���kc�u8)'��"�愦����sE+B�w����޽{�vMgI9��r	ͳ��Z8JGc8p�����?V�*~:)��v�G��b3w��Èt�F������a���i�>��w�e��q���_�qiʀ�7��;�)D5S�B����V�Q�dVG^#�����
�d��s"�����r���Ir�RW�\^nPq�3,^˪W��4Kho�n����p�0�9y(V����ө����Ԛ� ��,�S�����H?�2��/&�f�>lׯ�Q��l�lX�ɉj���᱌3Ч��WH�~�"������v]v�;ܭ9�M��/��x���b)nS��Nj��E�I�[�c��Z�g!�U��O�?�6�}�=NB�os@�HV�Wo���5���"x���_�@��騬3�3Q����9B诎4^����1@�}��vh����̍8	
�'6�M|���gX��9�ҙ���#o��ŢSPlBӬJ�^mS��8��hf�͆,��5��ɸ�W@"o��!�G������A��5�6���:��]���=qt����*�y�P��{�g}9���Pb]���x�
5�9�>19������/b�4��pH����F��ث�0�1L��;/�{C.�B��e�)|�G�$�mОHZY����F�e�f��4/�&�l1��A�7H�'Y���&���`���eGcX��SxD�b7l�s�����&��Sᬿ�����5��Q-=G�A�g��)8v��:�B���m�<�;�zQK��-3��Ql��6���۩F�i<�����"���b��<A�k@�=-�y-��_�_D�ݪN��&��`�#�M?���/���ږ-y�ΰsYJ;o�A�oaC�o�x���!��G�9<��?�O潟N�_%{�d�A�ԃ�O[���3,��gуz�[37��R�/?��NDB�n�e�,�n��[���6��	�=Bq��Ѳs��9B� rtS�3@vl(ĺ?
��h�l����r+�YN�J������a��S�����\�d��N���v�'g�x��o�������O+���/��z��⽀�b��5��8IЙ#��@��=�l�J�:�؉�����=��幄��jm����������2k�$M*O&�z�9x[��:B>�&�{Í�GP��T�v:��?�Q�>��C���^�����-��(�I�X/���N�"�ޙ �����UM��=Xj���.7�͑�ބf�����A�X��<�+\ �Yp��mBFz���B���wcٻ	�?�L>_���1�׋!sx�k�-�^�dQ+��3��8��|Gn�ނr����`��������^TxgYo�����#:��g��~<'�{��ޅ;�]!�����Z�H�X�����z�J�f�>�Į#��Y�,h��}yw��+���%��qx�ಟ�ī{�_ �l�s�~s���e���-!��GDL����Hf�����ns~��lo
�D��e�'��YS�R<C�k>��^�B�OO_�[[)�2�!�`�CH��{�7����~~=�&��NX�%�z�,��~��}�g�',.'˿��-�!��o3�SU�/��|G6[^��������8
���ѻ�2�l��8��m��g_'k�[���iQ��R�ƧF �F��z�1����!N��E���yx�� J ��&��%ҐH���.���@ϭ���r�}�8�y�[�0k^�6���D�3 �q̱�D!.��.^�ss>�˽�z;���,��b*rK�h���姎�lN�<V?By4�;`��^9���a�Ղ���#�BC�@Gl��v|�Q�k�C�A�hGX� ��c�a�k������'ǌ֣�4��ޑ��|���'&���8eͻ��'�s���㵙���;�:��<�_ϩ����?��|��.!��;���P�k(󝸜�B`?>/l�Y<p��8�TR�8��^5l#���頏�d��S{�z�3`�(�Ϫ���9#�%8�G�F�-�z���c�U<j�W�zQ��U�H���>�O��?i:=���Ky{���YoYeϽ����h�c�ս�ƙ�w.?r�)bPIG�{Ɲ q�������L���^L���B�����'�<G�u=��p��H/�T��m%����[��[�W���c�1�$�����Ľ�Ema��{�,�+�m�.��p��P�����8�G4)ѓ��xog%�1�'�z�w���]"��-��%����|C}�p	�H��M�mL�8�����$���I�Et��c3ɶb�9q��b��<Q<�9�.��wJv������C���*x�r�Բ�����N��<��y���>jg���3d��8d�x�OP���ќlF�\�n��VV|�V1;>���6Le30Q�M�;;�?6�����~��.W6�՝��ln��[�li%���:\�}�ۙ��0�d��Co���;���� 	ަx�,i��ݸ��3��3��l�ִ`XP�����`���^R�=Ţw[��=�h`�ƭX�&�LB��݀�"KQ���E�rR�ȃ��b+o
�=4��R+?���f��I�v������`����ƭ w>��k�X��	Qm��(����0����t����xqm�k��,�i�p�`���gQ�U�Zz��y�	��>=,R��@�$̓��w�?�g�q��,73�:�H��e��[�b���8&�mr����_���zY{����42}q�s3����A�������%�0�Lb7*�hx��!k{� ����q��;g�A�KQ��'�5G�#%� �`?ع�8�q��b���md@�s��Țա��/��NR<N\E1�����H�L��.A���#��_���#�����o<վ$�yl��A���9#��H��e؟�"ʂZ��͙V�̥D�t"�U�r";̐;�m�����l�3e��A�,�n�5D��n�iyg��T�i���<��lR���)E7�'��S
s^�5�AR�=�؜%y@b��8s,�=��w8��q�b���HT,�vHzf���у?����6�A��SH���;�f�~�ѿ�������jy_�s���4S���mH�~�1� dl,���_K�W�B!���K��ə"?c�W�^���G���qH{���^��udo���ӥ�����ˋ�-N�A��s�O?^졄�{C����������t0l��kP�~o�@�|�{ґ���E|��1t���"��hh�N*ӿ�p�7�G��<L�J�9�ay�a�:ؼ`x��if؎]NH���v�8	hVRo�p��~R=q��z�
�b��܌/c��:W��NC���BR�Ӹ�$z��"J�Bc�z�1�ۑ���=��2#��7�u2�d�J}�8��h�쥺�Q�Ĵ]�Pʃ�1����G'T%/<�Ѿ�L��~݉9B�m�_�LoZ/ދ/�r��܈<��V�`��|��8�1��]�N��ǋ��1_�M���QHj'�L-)v@��������؊0��z����2!c5D�F�om�[��UT��_�{Y&�lIح��N�fc�AX�nozoCh����v�Z�r��L�����fc7tZp[V���ɍ�9�x[���Ҿ%�G=J]өO<^܃=��l����;���^�m�OFs"9��R��9Z�Qb��<�V�E �r�:tdD ���2�a+9�/2%���-�pθ�}�Ev�I:0�uo���=d��X�d�P*{��p������-�(j�cIw��VŊg�o���,/�E���hh�,^g;�q,�nfhƴ1�[h��VR���j    Ԙ��ُ�?��uoXI�W5z�^f;����K^ �`������O�U�������1��F?'PçT\��[���٦E��{7oJ"�&���m�{rX�wbM8r�+w�Z��6{�L�9���M�B��7����:�krdH� xT���].˱�YH�R�n��n�мV�f%B%�u��ڻ��n���{�������ѹ`gq�^��j^��uD4G"M�TL�M���V����ބF0����ث��N[��S�J�N���J�56z��j(T�Z�{��s w�~웱��Hܹ�f����3|����m�":~˹��ް]�iH�e�k��A�3o�Ga[��N8�1�6Ӽi����:�/�#��ۭ����)��j��i>�վ�2[���D��?�y��w��
�AՋ�̀�x�i;��A�[k4�^{Cx2k����d�́R�;B-Q,�k�o0�ճ�K�<�4b-@j�:���3��i��J8��x���*�����EU��>G{�ٹK������Q[��a�.t�Ѽõ`"&�/ǲ�
w������n�ۡ���C���z�B�2��WW�N:P~˼|)_�8������#3*q$l�>���=D�e��r�����E��Q���K�9�����ܬ��o	�u:���A�ױ����.�+�7�Xϰ=��3�V�Y��t.���~���q��I�V���?�>�:��Y����1]<;�^BѼ�P}{��Ł��yK�ry�i��代�f�>I��`-�vӂ�`���ac�r��
�g����"���*���߿x[o����z�O�~D�������K� ��=Iy����JF�qn[��6ފ`���Wq��C;��y]�_��~�c��\���NÄg Лe�~ǂ8*�zÉjlj�^��c��R�(���ޫ���̞{vu��ދ��������P(*��ڞ���(������z+��Nǀ�9�{>R��B�E�*�z*'�� �q��B}o�.K�`D�B��h���r�o.}�iB�� �;ƵZ�	0d8�+kF��h��O�Gf��m����wuq�kW�C�py:� w/��X�ℹV�^� ���8��A��G�( �W�ں�n����2G7 7���{�s$fKf�SA"o��X�"l{��.=#�yH��]���䥳�b��v�KgX#������*�"%��^my��M^8q��SzS�9?pY��9�"���ON�+��y{'|K_' =,1� W0ãq"E8ޥ��#X-��������j#�>xV&:�5x��C~�c���h�xa�ǣ91��~�����-�b���\��	<�Z�M�A�!3z�,�e��;;2box-�k'��VN����^��,�� ~��5`��-����z����! P�H��7-R�ya9�m�?�����T�6��^�V���x���SG:J����n@l���-���8BWx"P��<]ڈ{|vy�'5^��P���]k�*�I�*7���<t��,� �D�۱xS=J$�K=�s���Zo�&����R͚Ə$[v�*��W�wTb�H8�:ʉ����!�iGm�@zك<�S(�0Su�I�Y�^Q+5���/ɢI��%�jR���D���ї�G���h/o�k����LH�w@y��C5�������S�$^���B�D�����SO��cGc;@�W>�<|Q�o�w�b����!��'��8��9��W���`i/��Ʃ ��*���3I��������ݷV����8f��Zg5�<����خGL�����h�SZ�a{Kɼl��Û{����[o�����V �V�8y���8��,v͚�.-�޲aw�(?��r��pWe�`q螇/��%���Q!����G�d�4�V�Hs�1�^�r��wx93L��Q|��Iډ����9�V�d�.d��: �N�� ��_�����gS]b�ރ�F%x�&����x+��"k�p�u��C�61�)���˻�k���Lԙ�(p��X1f*�[K��|�,��xߙ��=����o��|Խ �L_4��M4[+U�eSG��]%��@��������b��G�b�m�����众Jk�p��`��Y�c�C��/�k�1Y���]�r�Vl�Yx���HflSl�lk8{�Xc�z!�ۧ:z��QCs읧�N/�ʅ�� I����i�ªyD����{sH{zz�v�x�����E�^��c}+�>x7:�N6���8o�ğ^M�o3�WYMgDxX����$�w��y�cu�9����f��#3��_� v�q$;��.���N��N
�z��;g����zʽ��k^�h��,r���؝�
�}����S�o(9�9�Z0Gld[J�R��e�E����`y9\�U&Ry���_�V�F	D6�b1���آ�*�I�!-iz{��MZ���YL���� ���h���g����k/�C��9�c��aڻ�<�IJ\��=Ý�i�����"�!��T4�\j��������F�a��7P�Dfs�}L�����OV�<^܋v�UN�_	ӳs2�b�|/M�]��m���o%o��<�/�|	۳��B1}��g�w��a���q��w�\R�v8h�Z	��l��t�nĉ�^������{kmwz[m*��;�����CS��m��C*�=4m�+���vzu�e/M�Qf�x�J-�|oPV��ruf}F̂v��Zزy~;ς�����J�	2��y�D�igǣ��>�}�l��ǽ )HX�,V���F�^jx?)Q�!�>3�3�Y��pj�{��3��c�bs �o��G�Y����t4~�`�ُ�7�?[����;T� �t.k1?���#����+�F�&�������ƞh��k�l6�:���c-�m�g�M��%��p��ڼ>�tFk�e�̰�8gӪb��`��3��f��;�����d����n$�@ϋ�;w>\���o���;ƣ�˩��s�'��l��;s��=&!Ʃ�U�3��uZ�ؒ�y<,��i� ���6�CS{5�{���1u/H��8���$)������`|�v�7��3c��]�)� 	E�=����fb�T�|�K�m������a� �D���i���� 0ERB�/`y�.�%� ��B�N�3R���R�z��E_*��̫t+v�aN<Y�Z�|���&��kM��8�����MV�1Q�z8��|Nr��ܦ9ӕ ���\�b�p�.M�n䐙����𠹷2��9Z��d젦ܨ���?%j@"W;�WH~�IS1`�R��˪���a��H�7�2o6� ���aདྷ�s�'��mj�3�3��D��T�����+6����Qw�loo�Z
t�(�^�NO=1��k�s�($�'��r\���K5]����'���[S�X,�Vu���:l_�Gj���ɽݥHbZ�_�ao1�4NK ��#���I�/��	&%R��>������t�i����ѳM_�:�L�O���`L�����n��F`.���WE����ƎK�3߄�����{%��X3�ؙ�j��u:}�Z)c������X���2Y�ќ�	;��n�`p�C��AH�h���c�����)?�[s���މ�r*V�qB�2nVw�fK}QH���XI�Z���|_@��)��1��.yg��c�H�](7����jA
�'ItĒ��|���	���T�c�7�',}���蝧��7%X���d!tQl�N��Š��2	I���"�L�9U%A������� @'2|b�E[�L:B����Y�9��*�類$��w���p��O�vڂ��5Ԋ����N�<�ܑN�?i���Ζv���ب9ׄRvj��`���C53�*e.��M��5��c���z}d���.æ�tK�'�4A�{h�i�LA��9O��.(�Wu]�r��PQG+_(G^t�W��h�t~;i�ܲ��1)Ё��D�`s�-j��XO��\@b�z�T�������K	o1���:���^�    '���Ɲ���L�B�9ᛇCkrX*p@;u�=9;�-�w����?B��/�D��U
�o[��r��'<�S]���^�h	�1���ڦ��Js!d�}`���X�n��������mw��/�n�A��N)��-�P�l@e�F�i2i�������!��B�&�dn)����qVLt�'���m���Ħ9��9�M\���~�X;��ԏ�7��HRBJ?��pG�#ə	�m��y����T>x�^��Е�D"Ax�y�	�+S��=U��D��R������W���qS�� ��������2-�zO�ZH���Dϧ}�F?�(�-]}N�7o����څ���l{4uC�Wlꋼ����2aUP���fw� �������0SM��y$���2�ă��s���_<����S��묻��j�%���~܋�0L�:�b�p �I]k����A�7!�=�rt�7��IչOdړ�;+7�Ak*�o�ҥ�";L�&�S�����W ���P����FT���ny%ylͅ��k��y�v?X�w	�'JA��p�����EK�Θ;�ok[�a��PS���I��$��qn�r�v����A79�c�s���y�3~��<�51��P#��}��g�W$_�Xz�@���aۙ�a��Sjm<�V<Ak
9R')��v�ݮ�����5F���)1.l1�f^t ������T��Tio�r�q�&�U�7�������	|Ҽ�JH�ޚiO�K,�.�@	V˗{S6!0�t�r�سM6�Μ���YtH4V�њ�ёΫ�����ڄ���"rq�m� D�/S��B=�+�����J	^\w"?# ��Ý<��H�C����_�M�b�M
��T��	˂�e�w4N�0�(
��t8�$F�!_�	W�Ϧ�D�XM��|��B3�|��������r+
+�r��ı-EH��gqy&%x�Zd�18��$��S+c�Vs#�������K��ɛ�e{��`�������ڛT�&��n��ƚ� 	7H�J�G��P���v�
���r@I�ဝ�����j�n@�9haw�����É�HY�����`w���6,&�Hj��3��eA��q���ÝuG.�D5jI�`ee�0lH��n���@5/���²�X�G�ky!S���_��`�#As6�Pn�\���y�����i��"�sY�_s)�O��Foj��3�{q�|EJH�2���v��=8�w.q�L��ӾH-�Y	����KP��	�~�����n��&����D|���WN���z��|\���4�]��������?!�-'�8-�51,����LG_#A�K;&O��kfQ9�._{�	�X�X��'��/��&�&�~:a�.��O|��������_��ϒ�ļ  r2_b�k���0�w� ���:E�qo�=ϝ�1��eJ�Hd�C�kho�k��Z��K���K�Q:c�X�얐Q�>�$��)���*6�V�c�0e�Zp��ߔ&�(^	ob�����1�\ɖ?�u"�a����SͰv������I-ē�*�RM�$�� �&�(����$�����k��萧-뷣��X*�ܘ 1倅�W��q=�Y�豫IL1eH.a�U���4��E@a/!��}(�ڶ)�\��:����Y����Q���DJ�¢��޵��R,�Ix���au�0F�<�q��}��Z�E���f�*/?���Y�6���aE��=�`g����u�5	�Ps�e'U��o���!��}so7N�_�����- ���MRνU7m�{e�T.q�K]���咠� ���o+���f2����`����ĆB=] �)[���-�A*�O��'����ڎ?�R�Ul��6C[j��$���on#����;�+��R�'�wB+,��SVڏ$��о��u�-��da|+E��s��R����p�ڵ�!��|�G�̾R�Ӏ%;���������g@O�y�1-���K�'�ȽL��dyYrΟʍH�U���7�"��|��?�FsY�h4����	�8g�����4?�r�n�Y//)�*3W^�}�f���
,��8��:�Bx6�Ǎxc�$��3E�0�G%u�ۃ�e�Ɛl=1kS��UI*���^��a��$����4��W��>h�@�;0�˒�K��,9pi��2#�E���"���\����o
D�2�DH�?[�Tޟ/eֈ�)�n�b5��A��7P�H�$�&m)��0,0����(��0?[������ܘEѬ)Lp��=A��ބ��$09���E��tr��Z�kd&�-uI�������2ưE���p�f���T��sIo0^�����7UK�(����딌�`��EF>���Py
�����S;3���I�o��݆�4)�U�l���m}�c�b/Wb�D���|�I4݈��>�
�9&��C�9�sKV�QI�a��	�E4*_'�$$�y :�;�U�3�;��@��X�{������@Q}�j|K��j���\{��-e����M#v�ɡH='�\��7;�?Eg�Y2]�M�(q 9��<�M��}r�����5��]�7�HE�\� w�:^�/��D��.�����]^�6�Z���(>nۉ+&��&���l��:���F�2�v
�W�)�2?������:s��s��g��ǹ�%3���鿲��r�n�XM��hgG�:��T�)t��۷�H���/z���(d�Lڼx�N�����B�%}���)ZqK��x��\[�Ź m�.%_��C��G����Q�x��J��s���o��VN�� v�����VoҸaэx�A"D�7��)�$�8�,���M�Tvu�ZϥO���B�L-ٽi�������6W�`�Eo䳤K�䂓��� �	sNO��ҹ�j	2̥�;W>v@_>ӗ�r�927e���}�߷qIdiքs
��cw�F�zq�GznZ�txw5/I�f_x�B��]��i���Y�+�D�syY�[R�Q��C`Pk�Y��Q���C�d�u��;	V'e^��ދ� ��|�[��I�`k�&�I��Y,#Jɋw��2��f���a$�r� �	�'{��|���JO|�Β���$�7������<���fz@4��j�{��=��H��<q����U��$�>��Ld.���� �1��%X/�|�zz��D!�e���f�)����	v�ӕ�l��A��d60o�)�) �)�mW�Z9�r��P�н�k��M�l2��D���X` ���8x��]��>r���ڜ���OҼᯘ�;5�F&?e�q��m������s�%��p�w?�~�ŚX~vvPrF��4��̉u)��Ѭ6���Z�.�n~��3S��<v7L��k\��c>v�������D�F��E������ش�2��؊\{"ў8uX�15z�ީ����N��-��J�B`1=I��Y�h�_O�z"=����fЈ>q&b��{<���w.43�S���g�A|Y�t�78a9�����؉J�\�aD��e��x��*.�q	DO6�n�[o�h�iUJlMO<Ul�Et
���!Ȍޒ_�6N�����l���G^s9Y�L�Sd��c��{u\	~��S=��A7e�󮲄��I����s$�r��S��av��0�V��Y��������-��SV��g�����=�O�����ҙN*ͭ�K@98ڄ�� ��:�c�iFl�	��u�C��W\,{QX���L�x�w�:I��3�S�d咏�Q��d�c��pm�S�a��'�k�":�Iğ��L�,��#~��rs�@f��肯��K��Q�܈iM�x]f����T�G�	�ԗ�>rкJɦ�v��K�ݴ�0�z\d*;yUGᦇ����W��e�r$�'��9�	=��O��K�)��������"\͔ǪwrOvu?��x&<�+�z�4͓��g�%�ઃ��ʒ�.r�Xhy�'�M'u��k���ӯ��U�#E�6�>[�������!�@�/��ҳ���@����z���Q��Ĝ$��Jgj�D���Gj���A�(��dp�A<�	���pr�� h+��a��04
h��~:S��LK�}��á>ȣ��    &�T�%�De�Ѡ��w����
g}:1���n����>hL�8�C�\�c�H�xe��#Ah��G���5t��G����d�,�M�+_�N��*��S�H`�BL�'�RY�j}U���S̭���2zt[�١>H�}���>-6�UoN�3�<�91b�����Tv���?�X��d&�TOs����L�˼nEޓU0
�l�œ�6&�I~�At�;��)7�8����|/����u��⦧"PH&��W�]����k%r�/�v�sl����vޘt���\���,%��JX�k�������^���˪��c~�&Xt���ls�*�y��?q`�7�9ym�Q��'��0������DrV#�"�[]��	���� :�� �D'�������3|�ZAL�xX.$�4M		��I�j�z�~�g0�F��OH2�N�E��`�t�<	�Z���zp9�9�}�������{�{�%��$V�r�v�s�m~���!�Ē��
|�CJxa����)җ�#����R3�Hds`?3�{W��l�9��=Վف͎�)���5:Q���H���5"��k~�U������@�O{�bgE�g[E6�V�!;��ɶ���d �>3�ep�p����J�\�}!ٟ��-���Q4�H��JX�!Y��H��Gg&�%u	��9�L�& �-�~�~_s_7Jzy�u��������$$�s,��r�ޙc] G�z A�)!3���$Ȁ��/]k��dR��⯄��Ò)��<|ʁ�{^FOMtN�Y~J���5Frwn�c�䶢9��V�W��"�JJ)�$�(<ŕg�|�~�ĉ.�{��֓�JRI��ʄ�T��CV�����$J!|rpz.�ܠ�p�,:+k��_l)�K�S?3-yl�OoD�C0�9��9fz��L/~��r5�дWH� �%�n+alZ������Ҍ�m(�n>UL7>�$�m�F�#��br�`�	&��ƫҎ�:H
��_�-߶+~J�k-n�a��Dn�����4uyUX�N��,��>6�E�������..���8�������~����.Dj�f���M�C�c'�g<~̹�/����ba1�w�^���R5�HjLV�9%{�� ��+��K��qx�K�d�.��}��2gBr"	{~��R�G2å�dՐ}I-SPf�/�x�t�с����jւg���|:�:��H���6d��ztd���T����h/5���,������m�{��~B�T9��	�k��I���d>�Oi�����4+��8X��'K��|'����hkj��T�3Ţ��k߉ �$q��'y��k7<�p�ڲ��7�@�ME�|
��Jؑ�ni�%�ok�5u�̠+����my����]6��{*+p�4�ct~��|�W��h.�s鉛劧-�H�_7]�+�$�h��Nhs��H`��nXI��[�0=��7��/�.?x	��9U�O1R������5�#%����n�n�y��'�L������ENDO�-�	���@�25j{Nu��BQ�ۓ,a�$_�k���g2�������$�2��|��� �E����mx�fA��"��r�ɟ�I�n��nεoY��0��� I�d:��.F�ni�3OdL�~�mĪѤ'�,)G�,��A�hC��U�u*|����Æn�H�W
�>*ۋ�ݙ��5z�C�XL_�AkhZ�v�"�3����ORG������j
!���{��ݝ*�g��T�s�վ�^u>J��
y�W���D���u�~i�'.���Rod�b�!�}�9M�b�if��rMP6m��F��,��?��l������P9ʳ�x��j��s%�3��w�Q�?y�	<�l	I��������<�5S�{v~!6]'��d`Wn�k�#:�����7gL?dB��~�e�Z���M�#��O��9ϋ��]��0e�8�З�Q���ZK�g���+�������,���&6�Ó�RX� �Ul�o��N�1y|�t/п��1-Gb�hb��I))�l�������` (+�)��&�K d�j��e-�)��rk�'�X��(�Ω�;�lp��CrT
��k�6.���p?�3׳������,����k�i�R�9������yL7�
�D��Rڎ6�<�颤5K���>uWB�NY�!�f�7:*ۀ�j����&
C��|�N�϶�v��dp�i���)-9�|��D{����9��?fTc���tf�& ��f콡�2�MYIn�#��th�RQ��o4�l�|�w����Z�R�<oռ�]�=O�$ۻ����찪΀�گK-8ʷ�3�~Ӣ�6�%�|+	�܄�g�h�}UN��\�Ϭ(�잪���`s���T��W���Gl���f��P��SN$��v��I~��e����c=-��el��]|�������_�N�W���X�Nly��D���q��K?�7�jrk)��Շ�$��t���o�{�c�Q����Ӵ��t'8�=J�#�s��I���ML���b�y��;ֵ�3�M(keU�N�ؑ���1�� B��7ɛ�p9OBE~��.����ųc�������l��xn��F�����`!�w�^o�}7�+`l�r)ՓGST'���g����Fr��7�~�h}����O�C;�D��Ic�k2��k��)����ݘ(.4���4]��/|�@k��,����*�l���H��qP�A���2F����D�7@K�M�OP'i��	j�2��������� ���{mSI�m@m�z�H�}�(�gm��A�IK��y���}ŭ7e9+�Yd?9�x9A!��A&_�A��b��ډ>�'���WJ�gY�⊦tڔ	���O�+��fn��)'350I���b@�W�ڀ}�u�V������$���Y����/H,8X!L�\�wy�lI0)��I���S��Z��;�@�jm��%]V#���}���z6\KE�c�Ȕ�F�1'򦗠q��؜$���ٹ@
�� ��|J��%�����_��'��Β)�wT�I�`��m/����cMϝ�:Xl��]J�Cv�z��ɕ����W8�ҏ� ;�� �����.'O�-�،������E�~߄���X9�_���-�4N���ME<���)&��+؆�P��0��Q,���d��{�U�H�C� ��Pr���U��I��S^���m	���ggN�>�x��ܫq�cr�
7�-��!gH���w��Om��Ts�V�i���>�_�ހΤ��&"�St/۵���"��1�h�gں��2�!���KyO꡷��8,˖��v0�iF�9�������4QO0�v,d:�Yr�"rK��q���� �d��N�x�����b���RN�&��2Z��M��gi�	-�	�z.�9����%Tm���um8f��'���I!���5�Ј^�7P  ��VN��w7��?�ϒ��sd���3`�@���a����x?�E<jyP>���]H�f#=V��[�#���.MP�j�x-b��$�|�r�ңM��^O!��$�T3�Ԉk�9x�mz�K/�T0T�Ħ�^k-��O
P����'�e�N�i�/0�=����B=ZK�k'(��V�����<���D��Y���:L�0G=@vڡ� #̯��:)�dȤX��g�m*�(D�+_�&qN�(�ә�sK݊r#:ڈ�o�?>+|K�1zB%�.�6Kд®��u�K�1|����*}x6�.�hY��~J����v�h�&x8�:(�v\�n	N��ZE�oON<������l��ȿI%sI�%2"���iPO��2��5�姓��wF�X.w�r��gfZh���jh�P��L��wڕ�2r,����>gP
�������d��{�^a�J`��a��0z�g� ����@�^�%/�Ml�����@�J��o^ћ�8ȳV�&��Vƫm�@'��^���7�؃ �lL8��Ԛ�����&�{ob���<Y|�[|����x�{�X�5�{�{L�k�m&Z��)�w#%I]�3��ޟ�9�Q~�tn�%����2�[?����)X��5�-M�Y� ��ڜ    ��j��o}��B�F��0:Γ�(o� �BˣNIKY��%�*LE�}P}�`~!v?�%H#�h'w��u��;��DO'�]�SSF��lZ��+�<��s.l����vئ"�JW�Ai�'���ؾ�	��l�	��ߓt�W~�%�)����5?S�n!��SM��%5�M@q���T�Xl���O���Lڙ�Z�$��50�901�'#Wi��v�eȊ`T�+�~�I^�t��㟵�0ikN�o��R�Õg��dxB�6yL�7�lX�Ϸ�5���N��#a�-֛-�)�T����:�
p��	fa���e�Ay导j�Fƹꫳ6�kӷHQo�ʓ�����'�4��>j�m;RG��h�<�*�������Ɓ)u^!:�o��s�g�b��<{���VO�t��p&o�J< \e5�[ݺ-̂fr$FEt�%oԅ~<�*���R�4MtL;���0YN��p��dI��j����3z{�п�y)5�|U{Th {���%��Pn�k_ɔ��Am�Y�v�}	�R��,�>U��W��w��l�;�$k������۷�VvH���9�/:<�3&�]'��T��/��v�R��3cG�s�XSXL�vt]�����U��e>�˰�B(\��qv�A���8�|�f̞VB��%I.9�{�5�<%����u��^�W�l���q� N��G�A�U�
1ꔜ�"����:�:�}��e���
%;%�䭞>d>v�읠<���� ɯ1���Ո9f�w#���<���jf���>^<斻I�=�5Q;�pe�{��^�5���x�&"!�F4��	���3��t|V+��k.��Ev�IV'���$e����u$8����T�w�J�K��~P����6"B:jx��8m��R=ؚ{���I���j&@�t	� ��o\Jڠ�Y�W���ˡ^�+!��}q/l�q����G����7�t7�q(���Qpq7x���̛cg)��T�p���|cG�;7��`:���˘/':���|�L�y��"��[�Wv0�����xrZ=�����f^g��f�-~]�S+'t��僂�+����I��r� ��j}�:�W�E[�X�>�Y�y�L�HH�����2��@C�!�49e�ߣ�;W.(��?s�=�!�8�Y�2��$���&�]L]���'Lkp�9f��������;T�B�[*M �:�N����ċ7m#��_I �B�ME����
�x�s�i.�.s���hKO��x��Z�z'���+Q(��W|,�bSf��y�XI���=h��͎܄{ג޿�c���>�e1�#/��B���M�l��4w~P�ۥC}�k]�ZOp�}
�K��O���65I��Ky�+Z2�	���Vk�	��� �)9w {BÙ�?����.�Aq�k�_��'[�$图� Kjɖ좿��(�4D��U70���P��e2�M�B�&`3�Rͤ��DPD'������C�?�Dr��M\���ry�KR}K(�������-�6#��-s�-����E�j���t�c�8��i�gH��G�sϒ�.j0	��X�Y�pvֹ�	�.��}G��&�LD$��,�b �s"��v��?Ճ�SNb@q�m'ԗl�0������V�p���YQ�V�t4�'�s��_:]g��u�8��[΀���05�|�wr)�Fy-_���Ib�rz@zJ����>�K����ή��eZ���X��6�7����d����K::�@�-�5Pk+E��d[(y�*��r*�����q@� :U� |
���x�g �0��\��Y)A,Q2�T���-��*r�p��qh���K�����{�/��782c���ATA�f[2�0r�k�c(U"�P	[�
vZ3��i�/64�����=�y��s��:��|��
��,�(a�)�R�t���[����_Ⱦ����l�����R���`�XT;q���
	������<qֽ~޸�4��xd���1D[�y�6NB)�R�V玷��|��������jL&�8��a9ԋ�͓y&d�|���P5�z�ҾR o^S���u�a�i��7��V�;��o��J�8����#I%X�0�G>�Gl�.1��H�|˗��Ǜ[�YL5����I�=I�k����&njȷ�����~�
5��w�y��rlz����{��\7�'�t�h��l������WN��93�k�[�(�'�)>��}����� ��hO�p�����b�HB���`��0_Mܛ�5ۋX��L�Vtr_����Zk��;��3a�@�b�a䯴؍��>x;�g\��i��k�[���IL/[�O}��X�'��t"ܺ���4۪�8h^��*��uLPXΟbo�u���[W������ͣi�v�s�<��dl��ьE��(d�E:�Ф��>�_D�����s��P��z�L"J��Ǵ�s�(@J���m�h$S��Z���T���^����zx�Gz�'fIc�Sc���6k�f�Ϡ��a8ծ�3Zr�T)�܉dw����vcj"��o�U[�4+�4FI	���F9Q�?ao���GgI�J�J6�}�e\M�Js�p�rY��l����dIxe*������Xj�U�ᰦ4��ɯyjoz����|�\�n���!�4�R�=�L�px�o��&̚����D7�%�1�uI®�^�� ��ĖJ7�3���,��^̥�]�����L��|ټ��v*��dő�?���oao}�?�8M�b<�'���Թ[�+�g��;�[�G�i����1������3����i�H���*����YM}_�!��!�@^���bz)Lu~S��+�FI\B��t��"�|��%:b�2�n9��g�m�m��������ϽP(������� ���"�>J���x�?�Q��s�{˙�(/qVy��,��1�������
�3Z�b�4r����,�NO��ߏ�D�(��SJy���a�UT|�M����!ԛV�i=����<'��@U��}�)�C]a��2���ʩv� @����b�����n�e���P��/["��j}]�;�tc?өIⱨ���S8T�i�l��b�́a���-3.IM�SY�\�}.���JoB���#� �Qr�
5��Ӟ��L�`xˏ2l"���mFg�^�A�߷i��s�و�o���Sbg$���kE�=-YW���c�y3\�)g'3=�=���ԉ�J��86-k�~�K�N��L�u��'�;YlOh��6SM$�j�{��S{x/�y=M�c-%;���w��{.���B���tK=�V��&���h˥<3�σ�@t���MU���H*��̙,�
������e������'�h�I�a���s�׏?Oݖ)�����1��g=��j&b
��AS\4�a.>Y��pv����a��.IP͉ÝO�9yEԥ0�S�2�&�SQ����qs���W���	�D��/��c#���[��]I��\�G Ww)O�rg���xWgu�ݙSÇ:%Ñ+���f��{fՐ�S�3��ߔ�����S�y)�2�ο`���mxF���kXVO�xJ��P/�T'9B�2=H:�����G~�Q�N9@�w)0��Rs+o{^q�@���{)a}.D�"^ƶ9�Io���̡�V>�h�۳c���n�4�%�9�~ZR<���ѱ��x��U�!��$,�����-P�nIO1�����H$D+ykJrQ�5�p&^�Oyjh����;��������ۜ��`� o��էer3Qw��4|N#��!�?V���@Hb㫄^�'L��5�L*�dt���m6�!�x����۬���=<�ӠV�|^FP��� �d���y�����e*��þ�)7j�>\�R$N�����km��]�{)���nֶ�7����FW��s�=��N�4S�~g*G�5R]��$
S��&w��G/CӜ�q�J�n�Zӯ�~Z�L��hd.���5��_ktaA���Z�m��z��\:/�6�;�,q�'S������!�Nk���7�3	��ߧ<]��&ư�#�b��SH~Z    ԷM��s�J�-E�ĵ�_U��q<�|�w߭�F`�s�J�56�IԪ����W��ws%{~�]��|���l�������I�	o<o�[�{Q���3��L�ӽ|�J�-1"�?Y� �Y�@�4?�� �/r$[d��o6��>,�䜝fp�	&�����< ��mO^U	�ܧk���pLM��_�4��=9>��ƾ�'�x0,n����u�9Q��	�T�쵃��%2����·�y���@V��{jO��k��(��]	���ך��@�G�ЂRN�,���d���AX�um����l9��D���_����>�C���N�X�sq.6]=G`�M��{������ ֏5�_�C�A P<�Ⱦg��D��G>�N���)Z���MW���dUpز��|)��	�������d�W��ؓI	"t:��l�'��h-;m�z~$�; ct�	�l��A��9��!I���ߞ��Pnm��OO_`�|��0V��c?�H�	���\`��cZC�|�X$d1R,�J����7�#�X��41G��'#{Gk'u`��V�,���c�7��۴�tX��Pe��1��4���I�j��L��v�i@j�Y�欙}��%A���Xo�Ejs�"�W�G�8�ܧl�S,�	��ȗ)E������J�-����ۖۮ��<�>�gR��![����H�hN��`��cQ���8����0
)��x���5;�S��2}�����@���ϫis����柬������riF�x���_�q�h��6&��%�LD�*m���`���^���ǽоiΉ�;k�绒'�����	#�����q�\o��ck˃�Q�\J��s�xߒ:����rK~U��/�aBj@�]��9Y{��h��ҙ���{N�Oj=T�|zXܾ՜�h`��{3�r����ؘ��eysZ��	��4�Խ~��L7�zL�	3��X�,Qm	�őxg
�D���7S3&�s��?r��2I�O��a[c�R/��e��e�G��G��*<}�s��<�I��K}f2R��y�y��zw�"q.=Y�����e������������zmJM����<g���/�5�`�Z^l���05�B�&���l<0�̴;�v!��@U5$&ϋw�ߚk��ů��Be*� �n9wg7�/�ۜ_ۘ�h��)G^����m0�)�������}�����5�D��x�#�{�b�}��p�a��It��M���b>��~a�D���6~����̚�͌g���U�����s���D�H��ʍ�l7όv"�,,z�9Vc�VP��|�WI�j�\i�]	���)���^zyڳ��`f`���'��UX��f]��������~P�~S�Z^d7�N�,1n���р����D{y��"�D[1xKD���s�={������'	��5|a�<1��u`:Z��tO>��QȫsJwY+%%�6�����Y��%��'�UӔ�mr��Տ$�>�d��!�9r���$�>��yJwNzi�r�"�WK�\s���}?q���HPh���e�+M��g�L��$1��N���3����,FIK��fn�9jH��A�qB�U*���s�[�&lA�XEk��%p���7�.�=�8+�&����ff)��s�s�R1k'�
zJ�j�!J=�$O� �n�R�:P��ͭ-yD�_��s��T<�/c_2�@}�`9Ŕ���2�⠵Y,�}R�N?W�z�%9�*��2����f����g�	���ҁ��O:w�~uV�򑤅�|F�Y��}��u05bѡQ�z�3�$:[R]p����XN;ם��R@��usND#��
slR�]
P �q���Z���`9��z奈O����:G#��1����3j˙6�_3hD��H��}	�	^F��<6T\D��?,Ky[��}<|S�U'�^��Bފi���0�9i�\jפ�y�:�5�H!\�XR+��Vȹu�����
#��3��c	��׌Eȏ۳!�Y�����r����kb��ɗMZɱv�����XRv.��2�IUvRR�A��2��T��Ӥ	�s`�����>7̒G;���������Ź\s�1��ʾ�WX�_ꂅ>�pk�u۳)��a�3��j{������9h4����e3&7�� �c�@�ím�&�7�e~�`'�y���A��Bn�~��%������g�A�/�[f�/�}�<���N���		�H&���G�P��A��M�x�쉼�?�Ӧ0G_�#z�Dޕ�͛ ��9�j�!~�W���U�s�:�@|9�0f�y��%\H���q3,�}�"����s���.\�M���{�;$Ah�N���;3¾kEb�v~�u1��d��ω�\�h�����[_���j!�#M��~�౮�ě�6ȍ��X�\��(���6�NƧ_r�(�{���9�|$�&s¥q`�	�N2��ѡN D[dK|;~����N^{'�t��Ҕ�Bж�ޙ���ćCoJ�����ȏ�_�~ŵtF�m%R?�������.-�T)�[���=����y�#�K���~����O���y�^9r��#���ܽ��ٙ X�y��d�f����d�+�y���2�%��Ȧ)��%�����θ��a9[��(���ڜ[n�g��������<��wˀ9�#Q3�fv?��m��'�s��Z���2O\��s6��D�f0���Q��� ˏ� ��+)��f&�u��N��A��̷ք5�>O�w�5�8��;*��6���r������:�r7�~��G���I�q68_�q���%/� �֨E߼D�񥺾i�)����XN�{���cpiMb�����y��TP/,fR����6'�(L	v�j���n@A�{b�OR81����ke
㼔�h8�<�p�O_f���'��܏-��4m9q�f[��ƒ�uP9��^)7d9oy�{9�����fب�݉���1c�ҋ�c �< ���f���~
����W��b ״P�#�3U�g��Mh"����7v&��jG�N�d� ��m�mc�K�%��	�����Q�T�q�
����X��tN��r�ޙ�E#Ժ��λ�W�s�1m����{�܉A|/�2�
�������쮴�A�oOf�)�N'[�5�6�9X�)�uu�Y-����j��G��n�/"�{�p�M
� �B���sStO`l��;�՚���dlF=����	�-_r�[	R��[�भ"���K��*"��$��i����S���S�
z��^�F&gyk�D������s���LTMp2��a��s-׍�"�d�7e�?�
'��C�1}����s`Rɰ�[݇��rj��M����<�'�/I�3�2�6M�I�2D���5OP��f��nV<�(�B���HF�	�4�o���&�1�_O�����@���7��g�$$a��R�����b����<.v7v��x~*��"�v)6�B�^$�@�zA��9����N@"1?l8���A�+tM��N�h����\��ݕ�Os�Kd�������Q���m+���,Fn�
>|�΋�ν�_�T����<z�D3
D����=&T�V�q��5ٱPi7W3[�f�}O O=���YG����f�Z̜���~f 5Ls�%a�ۍ�SvΝ��mW���$�D��}�"�u�x�t���h��	�e���G�;�õKߘ�}��v7���@��MKnQ;�RH��~�'��);<���\�<����O�K5m���������.1��b�bA+x�c���u���E���R�R��6v�)�)�$��I��Z�y��';��.�`Yw�0�	�"%����C	�!���r�hӡZs~���k�z~H��5Y���t$w?���<�-1 c��'~�M�7�}��:h���a4�0�b3�n�WBc��B�tv�jS.G>W�|�[2�C�z㒫ߘmi��p�ρ�}��/���$����wu��q3�[I��ײ�y���]m*�G`�-40'�nk>��0���_k�|�cBp�
���g]�Z��i\H�*�YR���>N�:5zPgE��b�D#di+�rzNA�ky    O��:����O�R��H��bM&�砤�Z�.��J2U/UT��y�5�z�A(w��d�%�:��m�o���R���̍�����7�����̿F<h|�t���>��9����nkx�UvF���.E���l�Y�j!��aC0K�Zy�%������MR�b����/��}�k���cX�� D�/U�fq����8LM<X�>�%ܚ���(��Ca������_#�(����B��[����d��y�y�+�7f�e�j'hzF�[^6e���cgk�L���m�R�O�w7��J~�7=�/G��F�Y
6�",����<�v杚lP[ҋu|1�b��� ��e��C �1?q�M���Av>`�Űn��:����
z��=���N�۟2СCu����y`�I�z��DR^�٪S�q` �b9)��${���C����o&���;�4�J���5?�,��M�h�_ca� �<9�A�&n��U�a����<�t'1���[�� @)�9պ���>�&c�2M��k�a�#���-K&�K�tee����!�&���?VN:���^G���'&}�I���co��1�EU�>�U�!p����h;����C���Ze����#��cCjcF}��"
={�^����[`�Nӛ)a�L�?�����y������'ɝ���1�˗�Mۨ�Uc�	��g�GC�H+�%���A�6 5�'`��i�����f̸K�o"V�W,?Ў��xs���TD���6}���
P<����x��Y���"�-K?;U�1UY��j�<�<�DT���o�<y�y�D`�_� y�����K[�[�Yѳ�ކ~A+w^����v)�o>�r�}�묷N^��v���@n2�9\���n�*�bI���i�'Լ�J� �/����&�<��#����3��y���%�4��oG!��J==�(�y��<�\�л��2Q��'p�YR.����d ����C��{�ľ/W	�!��o��JZW?����<}J���u��Uv��[����K�.m��'�����=���%�ȞM�^��#m�����\����*�<{/�މ]�����ws̥���'�y�a��ܠԞ�8� ���>�ig��L/9�%��~�������e��vƯ9��p�gF�egB��r�u�=�¨?y��n�K��:��D|j:KTz�2�����s�3��r9�gri ������z}I%@b��Ɵ�Maf8>�b�1�G�����/�=�5�m볂u7S���ί}L�fl�S�9��ܒy0�C���0L=Y �Y���(}y*�\�G@��ʼ�A�g�񻛹rnV+��Y���1��vr���`Y
��M�݊q���a�
��_�TCX71U�2[ )�k�dphg��%�_PJ� �<i~������8��~m���4�c@q.��ٷ3C�[-Yv~A؇�͍�M�ٮю�D�,Bj������佃�,��P�˛�Ѹ�D��l�_�U�Ӵ���O�ȶެ���3�b%=RBr�W���<�#�z5bn��9�1���q���z�w�m�Rn��z���j�/iJ�F�����F�.vݐ���ވ��s!�|�_W윶���G��6�1y#,8�]��.��$'��HF�\6���\����~�HA�3�(�k��t�zΥN�i�j�\�/-)�:���{Ŝ�6W�O�Hx�����ѐ�>��%��Ncj0s�i���ϑ��?���[>
2J����$�캑/I�=�k���5�=�;�?����X;5Z��0T<�J�ļ�� 'PS�5]�B5���H/����PQϑ�Eԍ�e`�F&�^��.��f�z.��-��{`�~q�[`6��Q�Mdw�5��!KU�Zn� �Z,&)�׽qS��	�^�2�e���y�ׇ,�\e�Yo������@�G�Y0�p,g.N���	� ��rV���};��a�V�Fi����Qt��>���~�0m\� ����B���ع@,��n��C�w�b_2V��m�-�$�o�8O�;8>je�S9-sf���ew:9BIX�!�ū�&j���k��y?W0�S.D��贋����΂�ʡ%�����4�ZZI�ĩ��0hʫ��<�[�n%��S�{䵒
W��4���D��tsX�98�Z���≃B�������~�o�x:��<��~�xO�r̥K��4�-�6Hc9V>�}'���9����g�p�,mR���ح�.�Tax˴�h+p6�;����qՈ����Hѐ��M�]�UN�gOF�;�$e�򿹹�b����w�� �#�"�'_�D"�g����o��D�4�l3�$<O��7w�Ơa0�J6x��;�"3@�nD���d
闋Qj�c�Y`mI�����;-��z-/��/���H�x8ш<��y�)T�@&��>�D6a��
�.��p�K]r��bR�:��Հ�����b��8����V��yÌU%�x�S��d]���ds����m]����➷)7,���N�q�@�`ם���6u$�q�LM���䓠(��:W���=����_��ym7������@�y�5�A����cr����j0� ��d#���y^�D'�R�>�k	#�]�W�U	'��K{b�_Dr_j[+�4Ha�<��Ö��;!�31"�48����Î��n��L)�����r�%L.j��E~F��ג�=3@�W<R ���K �0�o�����O�Ǒ/�)T�"���Q�E��;la��E��8�r��S�z�'�^c��bK91�@�)�t�5'@&
�QQ�6Tp��/�?W�JR^o�ApƎ�x��B�Moں��b妼�ô��w�2��l �ހ���t�c�'I�U�Qvᣖ��$�=���٧_�a@�Խ��k���@k�,�.�{�7h>�d�E�7gtʗa �/�3A��t�睄Y�'�h�[R�l��(�H�E3e#�OB)�1p��o#����H(�ʟ1gk��t��:񣮡N���@�3�.����c�Os������A_��]N�����|FKj�I��M�IL�����0I�=�uy���1����9���5��͏L��EWfӔk�;���+��kuщ��������ssG��h�����B��<d�;1u3�|[~�����g��Ծ��t>osZn���nڴ�Od�'FK��v5�w�%Δͤq�|��I��7�Y�1�Ts9l'$NS5�*B�h{=�:��/�GrSr�]�b�u�^��?�n�g����N):a���$����=y�}���fr�Zo9(^W)ej.<�<�50�ɜ��
��çӒa�N���1l���北�B0f�a��*���0A�����y�则8��N$�-�a33�@�[� �2\����熔��e��֒*����F����R\ħ����A�GqYR��yW#�h��BO%�9Jɭ�k����#��ؚz�JP}g�m��j>I*fD��֕	����� ��4��_蚰�H�Xj�����/ϰ�%r2&�j��W��w�8�{�D%R#v#q�ߓ��s�t���(*u�����:��M����Nt���<iσ�h�>>�Vlno������7j�9�s��/�+��|�h�܅��T�`�@�9�I���Z��f��<����w�ՙ�(��ܻ�� N �a�/�=��j�ƴ)�4�ε���M㉨��[Um����+'�[%�!Y���H`�W���u�j;\u�ɖ>'��j����R�vv��57�g��ܓ�<�s�z���2Ѕ@�Ѯ����@^��o����Sԃ�9y�n��󓴑���J�1gWg�\���� Zꋏ�Ĕ"�7�N<ub����h�"P^N����C<��4kc����Jl5cE�K5��$CM]���Na�5�<�6]"q�ګ`�p4��c���E��s�����N2��ۑ�\�����!)�LWH��ǽ����&UH^۽_;wu2�Tw��.�'�����$gx�p��<-�վG@(fq����
u���X����d���X={��O+Ϧ�E�׻�\;j�b���M�GX:�Uµb��    �M)����T��;�Q�ܶ��Ǭ��6��&P$T��=yn8���R���~N��z<�6*���K<�L��m��Xå��m8�h�&�Z�MNy�ڞ0�7�8������/�p�!Eaf��9y��X��I0��w�;�J���m[���~+��=����!L���]-�l��;��Eo'�o��f�h��L�x�E�#�9�t���Գ<FއȝÜE���0Tfy�5ƣ�����0�)��A�M/�#��S!�<dQs�r�(�<\�VSP� 6E'�4Їq���"$UE"u���l|Q��S]3k��qm�iSǜ��SԂ&�~egŲ�fZ���FC� ;�<���h �Ih�r���=m�t�����8I�5�Չ3���7�r*�������ˢZHN�}\�nl�����j�9�r2Z���h��<����&,���?���2�#�7��w^�L=}A���tY�(A�zj%~TU������7�yFV�D��6^�2\�w0���$Z������I��[��Y�~��/!0ɇe�X�6��#@���|�T2{�#/9oڞA����'�� ��vBJ���pn[�'f�!(Ȃ�YSO�l�p�UO�����)�6�w��LA�^
C)��%�N��hNDh-Qv��ν�:�J��ٌGge�AJ�i�B�/ޜ�11Ӯ�N y�,�-[u6z�i�ޢ��Ş��G���q>���&�L�3^[L��s� ʐ?��)���䠲��B����1�+ɏ��뼕��ڗ����Y>
��	H������T)(�	�kZ�I�eτ�o2
];Te�QA���n��+/�='�B������ᒹDCKMvӊʷ���圞�Uޕ�؃������	�r|�}�R��Al)B�٭���A�����	M�D�T�;��O`R7ܞcϮ��c'~4{����[�M�J8Ia�yߟ��f��F�c����?���}�g�:=8�%o`+�;���/��s�y���p��@�WK(ט.6�!���HDH�Q}�mAk���Sc���O/)#�wx��%)�g�$��{�7������� K��[���\^]�^�" l�㖈4�e!����k���H�w۔�ߞH�]��DBlS3�Oe@C��_m@��x�v)��ꔽ6@mŜVh� �9���_��6�U��G+`S�z���(�ǻ�D1e���g��O�4۟�lO�}��F�{5���
P�	�  d��A��sz��p?)�Q�Rڴ#!m��r��+��f�I�f�����6�Z��E?�fi��PmMΰ��m�l�W��S[�c5 J'&0c�e%;��/)���Ղ��Hj�(�W���%���	+�4��`�C�#�b?-٤����K�!mIZ$��kyrfK:*�R�a݇��
�I�,ߑwf��B���{:dp�?	����ي�o8=(�FZ��=�˩�t��{I}�ԇ6-g���e�~�������K�3	�=��=c�B�DWQ-��93l=6'+�M��R�⒖J�0�3$������G^�N�$!%�c�����m��3��5�6wl׵c6�l��ГE��ȝ~���=�0�d�n�7�Fl�QL	�)�M�(�ŗ�{XKF�q��~	Ŵ�x~p}HR.:`�g�qJ���R[�G}1����j9�2R2:�c�w6��$�ԞH7�h��KG�izj��)��G�]����*�4�Nv9�#C�Vv��C�-7�'�����u�?7��9P���W&��T��^F�6��Zԑ��V�CyZ�),_��:���T�Kx��Ld��ޛ	�V�r	,�N���ֺG/����?1����Xڌ�wS7�^Cn�����|۵�ʭśQ������w���p�ju$�Q=O]<�M�Jg�_�6R|D��=9�����#O"9�9/8���l���bH�{�9�ΤP���L�����{���Uт�n�cu�m��\�Sq��|��uհW�]����N��t1���zm�1�V��9���d�
V�k�FT*�`ќ�+�*��匛Y4���#oz�!R�;���1JmOf�m��w�5sWbG����Z��93������W�4`�\���r$��ֵ)���I���U�	p�%×K���%0k�f{��m�@<��M�*��܆N_̎�ۑ;�d��(��I3e���C������d�܏a�2X�p���������}rW��r��h�a	�O��y�y�=�,��0�d�<�N�#�>�q��O.|Ȁ$l���yc������irO�c�z+�������ZO5�>$����p��[^�g��F`>˅�r:9�W�o �q%�̶3R�%�\u)�B'[6�}Q�ꊵۖM�����6@a�n�0rantn��R~���ZRR-�ps7�z�kU���v�Y�����6��N�e�K
B|��T�tx�/6����S&`�(Ez���<��7��A�����I�R�	����7-��]�a;�9H�&&ڵu�Z�s�_Ӡn�|�K�=r|5#	ےY���Ěrg�}s��I]�L��R��_��I�f�'ǹ8,���%�䴒�b-���ؔp��1�8I�5���l�_>�����TQ��!}ZYϢ���9yE�N&�,��B$�(�s5�(y�A1��@��ٺ	��D�Q��YN��ɳ�g{l�Z)�����gʟ���XN���� ),�]�.�U"�xU�S)+r�ra�M��e�Q*��-":��@ZUA�ذ�#��!�`{jȦ��5R�q�Ԑ\�+��Ɵ��y`�*��|�hjr�ґ˨�@	V�?��_�[�8�����Z��Α҃һe�Qm��ݏ����{�}��g������N^�舭Q{�߲|��ʛ�V��q�p]�i*��b�~��	��/��wM�[�ǹ�˿��n
=~��4#R0��0�J9��F��B�^�ս��7}��	���?�"�J�͙�>]���ߒčɚ�gA�];<x|t�/ɗ8�9�W�h��`󻈖��]�[
��,�H�C�H�0�lE�\����m��=���D�S��`��D�B{K��3�s�ݖ,�3�����C-˃1qt��G�r�/Ê���T���s�J��+�	N�%0�?��J��l��x��ضn%��S" �|�ق[�׳�I���v�=��G�d>���v�}弭�sN�Iy��d�_���<A;��([��(/_9�l�9�e�w��3�d	��O_�8��-�|��]&1+��k8(�`9��)O)>���&�+�/ε�`S�P��g�ٳ��ܹ� v`�~��s�>[�ɷz���J�e^��/��8B�7q�<�A���] Ƿ��6$V���D�6vS{^O����%��F��jU��<�ʄ���鍁j�8dP���2 OA
�w	
��u�m�~ߐ�Y�<�*��Ora2�%��8$�����ʙ�Ȋ#\�{�yf�n<�cI#��V"�4R|N�Ī�/��������VHO��|��gJ�N2c��<���m���Iݳ��N�OaPO�m�S��6.R��蠉D�ծ�׭�OԼ/�cD~ݞ;��v���]Ӈ%���M	rVK:��1�TM��{�2��c�j��[��gzĥH�Ԓ����Z��ǜz�Vr,� q@i�����6<Q�'a�d��|�?|0�G�����HA�b�}I%�4��'nS��a I���ThH��lK���[uc�U��ar�k	'�G����ǗC63�_�����m�dE	IY��ץ,�r�f7%����|�O�O>�K�?��ej��#_�	���l&�|�����11�'��{ǜh��Fzj���c}`��|�+����9y�i��g�v�$ �w'/xR�\	�Ӈ	qX4YLD�G����xPL.3�!`d��$&��(Z�����z�S������V�l�f_~۵v����M�k~�٩EIN<؃�P�_�^A���3����?�qN�A��K�U�*l���R�C_!�P3:?{Ə�ʙ��j~h7s�%�b�v��-�J�r ���Mt6f���1A�K�`������g���=�^�۬� ���"��-i�*z�A�4� '  ��s�l'�ރ��7�/9c��AQ�u�����[l}���)���g{���=Sg759i��S��a	�R���K~��Ykq�`S�ԕ�Τ�b������ �"�L������o���^�7��ZCFa��LiI��e?�����zFӧ���i�-������1!>Ye��>�|�d���������Y��l1�J��Ku�3�8]�5���1���ù�L��i�s�B������Z⨃��9�'8ãy�q���R�_��Z��-�$��'� �&kJ����]µ��q�/���́dS�_���9�Q/7	��L�g�~����ع��]
���������J�m�`'�r��s��!t��L1ܦ���k����2��(|����eU�9�2��O�t�X96�	�ʯKZ�^�A8WU�-H��l7o�=��\��4�1ŗ�򇜷��n�G�&��$�P.p�RnKf�M����"����������S�1Nũ0N�P2;u���� � 4@�ƣ��Z<��V���G�����R{����[  �����������=��ܯs|elpJu��^5sx�h�O�{n��h6ނ[?��}��n���-dFM���4��M�Rf"�� ��������F0��{_� ��=U]�Q7��w°e~�Q�����X�M5ˑ��WlЯ���Ѯ�1/��o��4#�[��Qf>�I�%Q;R[��b$�Y������Lƴ��Ne�s2�+'C��\ߙ-��uA�V�"7�sEcԑж�\^�N�pK��	*��C�!՜a�Q�!6dۃ��?u�Y��6�o�*��&R^K~4� �G��Hа;m=�*�b��&T������1_�A)RC�!�I��%Z�� Y�U;�Bc��2"5kj)�p�9ǥۗ.��T|���s�s�����Z���"ΓbY�(m���<��攜�;�EI:��m�ǅ��Ma6��ڐi5�~��LS�+.`Y���qv3�'YyАғ����q�6\�S!�l����X�S�̃׼J�P��徲���ꄄRF���!�#E�*#a��({��s� <��q6� @^ ���#b�<�W��#�ib���ş��,Dm��%r.P：)Z)kE���h�ذ L����t�E��{b�<i�L���@�UM�=uՕ������®]:c������w`�Hʸ�N�M1_q��zAf�G��a���f�X�e�E���2�ވ�6�."����/�9Pjc�r�/p�%��Eޑ$��`�X�,3	�N-�'��S)��5l�o��,L�(!��TvQ)12��O��Ɗ��ot�k[������0��j�^��7u�OꂜL���kcJD �)�h��C��!��,#؂�kFy�y��*��&{���X�a���k0��>���9��1<΢:+��
7�"x�鑏e�r{�J�4�_4�F�m���l����ݘfQ;�˶��8��mK����r�aڠ�i4���u�F�흕�n����W�T}�sU�M�6��_2B:�`�i+5 �]��X��Gmπ��l�b��A�lHr��7�q��`�� 8�,p���]�?�ߖ^.���s`w�|�������r�&l��`ld�\+����2Ej�M]���m�<��v�9��Ŵgt[�DYe�|>��t=���ԓ;�sB�L���g��EbY�43v[ ��D
�
p�����E���_�����bf���o�0fdd���+��z{�D��T�Ԗ����� ayh��ixά{oO��f���®��[�>
�zKM+��k�E�K��A���]�?��x�(_�+(ۂ	�ԆM!��|��;�^��ϓ����]��m֑�ba��V%Xi� �c�L6��"���(|u�Ѵ������Q4�N��[��f�p	�KX�Uk�F�"JL�6��7j��C�x���I�97��P�����>��J%��i��n�����ZJ��٘)�g�����
:�ؔ�� ����*�@��MGĒ�Z*$šj��2KI������$8�k��U��jZ��CHq�8_�CtZ�֍��%�L����{s��`S;���aа2��.��}�!�"���r�p:��n��O1�j)Z��Z�g�����4!�Y�s�������lڲH�c1fW�ڑ4c��?mP[n��o.��
^V�Y�=�)LHp4ؼb���T��ғ�2�I���� �s���;5l5�ʷ�9t�:<�Ԏl_WjC��\9��O���@zR��� �Y�OCa*��Y.rI�?|V�4��ш�i"�m�#^�C��Zm��WA&�N�s�Nj�MNو����GHȲ�tP�=�ĝT���H���A}��_˵۲<��^$������0�IFQٻp.�n�W��溱�
�ZO��TK������@yTn�3���'iӧ��S �lf���)�)�p�C����,Kj��Q���c��:��7��]�S�$�\�� �������T��/ç0��f�]��d�$�Wyo���j�fQ2�w���'_��W ��̔N!/¹���`k!_�Ib�,識�4��f���%g���u�e�R��&za��=U, n�ҝt\�`�<�I���پb��|ҽ�*�٤'�%��B�%4*��r�{�c=���`~[k(lO�i{r�
�/B'9�ˎ��D�.F����7�������Q�H�"ө����%�S�R��@�JH_�_V��H�B�ZMUaM�B��v�W�D��un����"�p�J��&���xy���h0�f:�����:��%��9g�N_6���bf�S���0/��u���� �P�3
 C�@�`���u���	x����B���d<ߩh(��VG���O��3�4��=r�v����#y]�+���t����~�`�;�x�+I��=�ͮܵ�M������P�v��,��ؐ-~�R*$aS^��ǹ"p�:��\g^����:2tN���̴EE�RI�ߌ��26?���}�.��%Q1%ż�<����`#o啘���C/�!M�qU�gr旸��yg�u�������#.�wk�NƕyƤ̓t�/ߪ3l��?��`~r�6BU&���S���	&�$�.��?�����)P"(n���V������tz�k��f�S�꼂�\\�E)g�kZ{�xQN/��$n���**�� !�-�� 
���i�ŧ��Mz��4t����W�����S�g��7�8��ې��V�j�m|��{9v�sez4�:�}a����_���g�����ƧHm���|q�j>�b�3C�$w��0(ʽ��5}��>==�?_���6�]+�����?J���?K���){�ן?�����4Z      (   �  x�m��J�@�ד�)N�ߝ���	ZEl�R#�+��PP�-��BA�M�T+���op�<w�jKJ�Lr�9��)��+OP���A�i��n��j�Icl�qT��bp�Y��QX.��NX��[b�05�5=҄��2�Q�&���^�+AT��G�0<�+oJyFؖ-�	�>}%FpFC�K����9^N�R�X��ᥜۯ.�X�8���5�`����{���X�����خ'=h̀� �j�ߒ8�;\���l�S5���+��rG�4G=-M�x�� �A���ti����H�`'���E���΂<����4�t�;����Ɋ}�Ա$���#ߠ���Ѭ��fr���>S!��N�!�Zb��.���?���$�d�<��F��!�y��L�	���U�rW�YO��{�r=rcDO��r��5�'v����|��\��,f;g�/E��S     