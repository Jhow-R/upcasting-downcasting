# Upcasting e Downcasting
## Upcasting:
É fazer um objeto se passar por um objeto que seja um supertipo dele. Ele sempre funcionará já que todo objeto é completamente compatível com um tipo do qual ele foi derivado. Como sempre pode ser realizado, é possível fazer implicitamente, ou seja, o compilador faz por você quando for necessário. Ex.:

Gato g = new Gato();
Felino f = g;

## Downcasting: 
É quando o objeto se passa como se fosse um subtipo dele. Não há garantias que funcione (pode lançar uma ClassCastException, o que obviamente é um erro de programação) e pode haver necessidade de conversões. O compilador só aceita se ele puder provar que o objeto se encaixará perfeitamente e seja de fato aquele objeto. Por isso deve ser explicitado pelo programador quando deseja essa ação. A coerção ocorre em tempo de execução. Ex.:

Felino f = new Gato();
Gato g = (Gato) f;

Felino f = new Leao();
Gato g = (Gato) f; // ERRO... excessão ClassCastException

