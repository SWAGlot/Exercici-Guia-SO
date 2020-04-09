#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int comptador;
//Estructura per a l'accés excloent
pthread_mutex_t mutex =PTHREAD_MUTEX_INITIALIZER;
void *Atendre_client (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	//int sock_conn = * (int *) socket;
	
	char peticio[512];
	char resposta[512];
	int ret;
	
	
	int acabar=0;
	//Entrem en un bucle per atendre totes les peticions d'aquest client fins que es desconnecti
	
	while (acabar ==0)
	{
		//Ara rebem la petició
		ret=read(sock_conn,peticio,sizeof(peticio));
		printf ("Rebut\n");
		
		//Tenim que afegir-li la marca de final de string per a que escrigui esl que hi ha desprs del buffer
		
		peticio[ret]='\0';
		
		
		printf ("Petició: %s\n",peticio);
		
		//anem a veure què volen
		char *p = strtok( peticio, "/");
		int codi = atoi (p);
		//Ja tenim el codi de la petició
		char nom[20];
		
		if ((codi !=0)&&(codi!=6))
		{
			p = strtok( NULL, "/");
			
			strcpy (nom,p);
			//Ja tenim el nom
			printf("codi: %d, Nom:%s\n", codi, nom);
		}
		
		if (codi ==0) //Petició de desconnexió
			acabar=1;
		else if (codi==6)
			sprintf (resposta,"%d",comptador);
		else if (codi ==1) //El client demana la longitud del nom
			sprintf (resposta,"%d", strlen (nom));
		else if (codi ==2)//El client demana si el meu nom és maco
			
			
			if ((nom[0]=='M') || (nom[0]=='S'))
				strcpy (resposta,"Si");
			else
				strcpy (resposta,"No");
			else if (codi ==3) //Dir si és alt
			{
				p = strtok( NULL, "/");
				float al = atof (p); //Extraiem la capçalera del missatge
				if (al > 1.70)
					sprintf (resposta, "%s: ets alt", nom);
				else
					sprintf (resposta, "%s: ets baix", nom);
			}
			else if (codi==4)//Polidrom
			{
				char nou[strlen(&nom)]; 
				nou[strlen(nom)] = '\0';
				for (int i=0;i<strlen(nom);i++)
				{
					nou[i] = toupper(nom[i]);					
				}
				
				int polidrom=0;				
				char nouInver[strlen(nou)];
				for(int i=0;i<(strlen(nou));i++)
				{
					nouInver[i] = nou[strlen(nou)-1-i];
				}
				nouInver[strlen(nom)] = '\0';				
				
				if(strcmp(nou,nouInver) != 0)
					polidrom=1;
				
				if (polidrom==0)
					strcpy (resposta,"Si");
				else
					strcpy (resposta,"No");
				
			}
			else
			{
				char nou[strlen(&nom)]; 
				nou[strlen(nom)] = '\0';
				for (int i=0;i<strlen(nom);i++)
				{
					nou[i] = toupper(nom[i]);					
				}
				sprintf (resposta,"%s", nou);
				
			}
		
			if (codi !=0)
			{
				
				printf ("Resposta: %s\n", resposta);
				//Enviem resposta
				write (sock_conn,resposta, strlen(resposta));
			}		
			if ((codi==1)||(codi==2)||(codi==3)||(codi==4)||(codi==5))
			{
				pthread_mutex_lock(&mutex);//No m'interrompis
				comptador=comptador+1;
				pthread_mutex_unlock(&mutex);//Ja hem pots interrompre
			}
	}
	//S'ha acabat el servei per al client
	close(sock_conn);
	
}


int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	//Inicialitzacions
	//Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error al crear el socket");
	//Fem el bind port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// Inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	//Associa el socket a qualsevol de les IP de la màquina.
	//htin1 formata el nmero que rep el format necessari
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	//Establim el port d'escolta
	serv_adr.sin_port = htons(9030);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) > 0)
		printf ("Error en el bind");
	
	if (listen(sock_listen, 3) <0)
		printf ("Error en el listen");
	
	comptador=0;
	int i;
	int sockets[100];//Tindren 5 sockets com a màxim
	pthread_t thread[100];//Tindren 5 threads com a màxim
	
	//Bucle per atendre a 5 clients
	for (int i=0;i<5;i++){
		printf ("Escoltant\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He rebut connexió\n");		
		
		sockets[i] = sock_conn;
		//sock_conn és el socket que utilitzarem per aquest client
		
		// Crea thead i dir-li el què ha de fer 
		
		pthread_create (&thread[i], NULL, Atendre_client, &sockets[i] );	//podsa dins del thread un identificador de thread per utilitzar-lo en el programa principal si és necessita	
	}
	
	
}

