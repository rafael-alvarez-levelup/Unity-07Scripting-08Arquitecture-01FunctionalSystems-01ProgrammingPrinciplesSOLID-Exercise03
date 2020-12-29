**Requisitos:**
- Unity 2020.x.
- Visual Studio.

**Objetivos:**
1. Crear los siguientes sistemas e implementar el principio de sustitución de Liskov:
* a.  Sistema de vida
* b.  Sistema de daño.
* c.  Sistema de enemigos.
2. Estructurar y comentar el código correctamente.
3. Compilar el proyecto de Unity para Windows.


**Procedimientos:**
1. Crear un sistema de vida que almacene, reste y sume vida y aplicarlo a los prefabs “Player”, “Enemy1” y “Enemy2”.
2. Crear un sistema de daño que reste vida a los prefabs “Player”, “Enemy1” y “Enemy2” cuando un proyectil entra en contacto con un enemigo o un enemigo entra en contacto con el prefab “Player”. Cuando el jugador reciba daño aparecerá el prefab “DamageEffect” como efecto especial de ese daño recibido.
3. El “Enemy1” recibirá la totalidad del daño del proyectil mientras que el “Enemy2” recibirá una fracción del daño del proyectil.
4. Cuando un enemigo sea destruido deberá crearse el prefab “Explosion” como efecto especial de su destrucción.
5. Estructurar y comentar el código utilizando las regiones adecuadas y comentarios.
6. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raíz del proyecto de Unity.