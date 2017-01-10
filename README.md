# Examen Desarrollo de Entornos Multimedia Diciembre 2016
Examen de la asignatura Desarrollo de Entornos Multimedia Interactivos de ESCAV.

Enunciado del Examen:

### Ejercicio 1: Juego de Futbol ###

1. **GIT.** (0.5) Crea un repositorio en Github con el nombre “Examen DEIM” y añade la estructura básica de un proyecto en Unity.  Cada pregunta del examen se subirá en un commit cuyo summary empezará por el número de la pregunta del examen seguido del título. Puedes usar la descripción para añadir notas aclaratorias para el profesor. Ejemplo:```#2 Escenario Fútbol```
2. **Escenario fútbol.** (0.5) Crea una escena llamada Fútbol y copia el diseño de mas abajo.

3. **Movimiento fútbol.** (1) Crea un script para el jugador 1 que mediante las flechas del teclado mueva a uno de los jugadores.

4. **Movimiento fútbol II.** (0.5) Crear un script para el jugador 2 que mediante (AWSD) mueva el otro jugador.

5. **Físicas balón.** (0.5) Crea un material elástico y aplicáselo al balón de fútbol.

6. **UI fútbol.** (0.5) Crear un interface de usuario con el marcador y aplicale un tipo de letra personalizado

7. **Marcador.** (1) Crea un script en cada portería para que sume uno cada vez que el balón toque la portería.

8. **Final fútbol.** (0.5) Cuando uno de los equipos llegue a 5 carga el siguiente nivel.

### Ejercicio 2: Juego Nave ###

9. **Escenario Nave.**(0.5)  Crea una escena llamada Nave y copia el diseño de mas abajo.

10. **Nave (1).** Crea una nave con físicas que al chocar (excepto por la parte inferior) desaparezca.

11. **Explosión nave.** (0.5) Crea un sistema de partículas para que explote la nave.

12. **Reiniciar Nave.** (0.5) Cuando explote la nave aparecerá un menú con un botón para reiniciar el nivel.

13. **Impulsor nave.** (1) Crea un script en la nave que al pulsar la tecla espacio le aplique una fuerza hacia arriba.

14. **Rotación nave.** (1) Usando la función rigidbody2D.AddTorque(float rotación) crear un script con el que pueda rotar la nave usando las flechas.

15. **Final nave.** (0.5) Cuando la nave llegue a la plataforma final carga el siguiente nivel.

### Ejercicio 3: Juego de Robot ###

16. **Movimiento Robot.** (1) Crea un script para mover el robot hacia los lados usando las flechas.

17. **Disparo Robot.** (1) Crea un script para que al pulsar una tecla el robot dispare un láser hacia arriba. El láser destruirá solo las naves enemigas y sumará un punto a la puntuación.

18. **Naves enemigas.** (1)  Crea una nave enemiga que se mueva horizontalmente y que cada vez que el jugador pase por debajo dispare un láser.

19. **Asteroides.** (1) Crea un generador de asteroides modificando el siguiente script.

```c#
using UnityEngine;
	using System.Collections;

	public class generadorScript : MonoBehaviour {

        public GameObject[] columna;
        public float tiempoespera = 3;
        Vector3 posicion;
        float timer = 0;
        void Start () {
        }
        
        void Update () {
                if (Time.time > timer) {
                        //	AQUÍ EL CÓDIGO PARA GENERAR ASTEROIDES
                        timer = Time.time+tiempoespera;
                }
        }
	}
```

20. **Muerte Robot.** (0.5) Cuando un láser enemigo o un asteroide  toque al jugador se reinicia el nivel.

21. **Final robot.** (0.5) Cuando la puntuación llegue a 5 carga el siguiente nivel.

> **NOTAS:** 

> En cada escena incluye un texto en el IU con tu nombre en la esquina inferior derecha.

> Elige solo 2 de los tres escenarios propuestos.

> La duración del examen es de 2 horas.

> Puedes añadir funcionalidades extras e indicarlas más abajo asignándole un número a partir de 23, un título y una descripción.
