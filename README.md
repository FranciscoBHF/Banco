## Diagrama de clases - Banco.core
```mermaid
classDiagram

class Cliente{
    +nombre: string
    +apellido: string
    +saldo: float
}
class cuenta{
    +CBU: int
    +saldo: float
}
```