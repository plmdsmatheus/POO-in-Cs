class ApostaLoteria:
  def __init__(self, n1, n2, n3, n4, n5, n6, numeros):
    self.__n1 = n1
    self.__n2 = n2
    self.__n3 = n3
    self.__n4 = n4
    self.__n5 = n5
    self.__n6 = n6
    self.__numeros = numeros
  def get_n1(self):
    return self.__n1
  def get_n1(self):
    return self.__n2
  def get_n1(self):
    return self.__n3
  def get_n1(self):
    return self.__n4
  def get_n1(self):
    return self.__n5
  def get_n1(self):
    return self.__n6
  def set_n1(self, n1):
    if 1 < n1 < 60:
      self.__n1 = n1
  def set_n1(self, n2):
    if 1 < n2 < 60:
      self.__n2 = n2
  def set_n1(self, n3):
    if 1 < n3 < 60:
      self.__n3 = n3
  def set_n1(self, n4):
    if 1 < n4 < 60:
      self.__n4 = n4
  def set_n1(self, n5):
    if 1 < n5 < 60:
      self.__n5 = n5
  def set_n1(self, n6):
    if 1 < n6 < 60:
      self.__n6 = n6
  def resultadoa(self):
    total = 0
    if self.__n1 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]: 
      total += 1
     
    elif self.__n2 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]:
      total += 1
      
    elif self.__n3 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]:
      total += 1
      
    elif self.__n4 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]:
      total += 1
      
    elif self.__n5 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]:
      total += 1
      
    elif self.__n6 == self.__numeros[0] or self.__numeros[1] or self.__numeros[2] or self.__numeros[3] or self.__numeros[4] or self.__numeros[5]:
      total += 1
    return total
  def __str__(self):
    return f"O valor de acertos é {a.resultadoa()}"

if __name__ == "__main__":
  a = ApostaLoteria(5, 9, 10, 3, 30, 20, [5, 9, 10, 3, 30, 20])
  print(a)
