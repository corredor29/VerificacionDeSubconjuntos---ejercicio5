# Verificar subconjunto con suma dada (C#)

## Descripción

Este programa en C# para consola determina si existe un subconjunto dentro de una lista de números enteros positivos cuya suma sea igual a un valor objetivo.

Se utiliza un enfoque recursivo para evaluar todas las combinaciones posibles de elementos.

---

## Funcionamiento

El programa evalúa cada número con dos decisiones:

* Incluir el número en la suma
* No incluirlo

Esto genera todas las combinaciones posibles hasta encontrar una que cumpla el objetivo.

---

## Ejemplos

```id="z9f2mx"
ExisteSuma([3, 4, 2, 8, 7], 6)   -> true
ExisteSuma([3, 4, 2, 8, 7], 26)  -> false
ExisteSuma([4], 4)               -> true
```

---

## Casos base

* Si la suma llega a **0** → `true`
* Si se recorren todos los elementos → `false`
* Si la suma se vuelve negativa → `false`

---

## Estructura

### Método principal

```id="s2k8lm"
ExisteSuma(int[] Numeros, int Objetivo)
```

### Método recursivo

```id="q1n7we"
ExisteSumaRec(int[] Numeros, int Objetivo, int Index)
```

---

## Complejidad

* Tiempo: **O(2^n)** (explora subconjuntos)
* Espacio: **O(n)** (profundidad de recursión)

---

## Tecnologías usadas

* C#
* .NET
* Consola

---

## Autor

Felipe Corredor
Ejercicio de recursividad y backtracking