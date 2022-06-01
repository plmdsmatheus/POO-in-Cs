class Data:
  def __init__(self, dia, mes, ano):
    self.__dia = dia
    self.__mes = mes
    self.__ano = ano

  def get_dia(self):
    return self.__dia
    
  def get_mes(self):
    return self.__mes
    
  def get_ano(self):
    return self.__ano
    
  def set_dia(self, dia):
    self.__dia = dia
    
  def set_mes(self, mes):
    self.__mes = mes
    
  def set_ano(self, ano):
    self.__ano = ano
    
  def __str__(self):
    return f"{self.__dia}/{self.__mes}/{self.__ano}"

if __name__ == "__main__":
  d = Data(27, 2, 2003)
  print(d)
  print(d.get_dia())
  print(d.get_mes())
  print(d.get_ano())
  d.set_dia(150)
  d.set_mes(20)
  print(d)
