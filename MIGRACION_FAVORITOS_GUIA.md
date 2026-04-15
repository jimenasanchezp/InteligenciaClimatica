# Guía de Prueba: Migración de Favoritos a SQLite

## ¿Qué se cambió?

Se ha mejorado significativamente el proceso de migración de favoritos:

### 1. **En `DatabaseService.cs`:**
   - ✅ El método `MigrarFavoritosASQLiteAsync` ahora es **asincrónico**
   - ✅ Crea/valida la columna `FechaAgregado` automáticamente
   - ✅ Mejor control de errores con try-catch para la migración de columnas
   - ✅ Usa `ExecuteNonQueryAsync` y `ExecuteScalarAsync` para operaciones async

### 2. **En `Form1.cs`:**
   - ✅ El botón `btnMigrar_Click` ahora es **async**
   - ✅ Muestra estado "Migrando..." mientras se procesa
   - ✅ Mensajes de éxito más descriptivos con cantidad de registros
   - ✅ Mejor manejo de errores con información detallada
   - ✅ Recarga automáticamente la tabla al finalizar

---

## 📋 Pasos para probar la migración:

### **Paso 1: Agregar algunos favoritos**
1. Ve a la pestaña **"Favoritos"** (botón en el sidebar)
2. En el recuadro "Agregar municipio favorito":
   - Selecciona un **Estado** del combo
   - Se llenará automáticamente el combo de **Municipios**
   - Haz clic en **"Agregar"**
3. Repite para agregar 2-3 favoritos más
4. Verás que aparecen en la tabla (DataGrid) de arriba

### **Paso 2: Migrar a SQLite**
1. En la misma pestaña de Favoritos, busca el botón **"Migrar Favoritos"** (en el recuadro rojo)
2. Haz clic en el botón
3. Deberías ver:
   - El botón cambia a **"Migrando..."** (en color ámbar)
   - Aparece un popup: **"✓ Se han migrado exitosamente X favorito(s) a SQLite"**
   - El botón cambia a **"¡Sincronizado! ✓"** (verde)
   - Después de 2 segundos vuelve a su estado original

### **Paso 3: Verificar que se guardaron**
1. Abre tu explorador de archivos
2. Navega a: `C:\Users\CaroS\source\repos\InteligenciaClimatica\bin\Debug\net8.0\Data\`
3. Abre **`favoritos.sqlite`** con una herramienta SQLite (ej: DB Browser for SQLite)
4. Expande la tabla **`Favoritos`**
5. Deberías ver:
   - Columna `Id` (auto-incremento)
   - Columna `Estado` (con los estados que migraste)
   - Columna `Municipio` (con los municipios)
   - Columna `FechaAgregado` (fecha de la migración)

---

## 🔍 Si algo no funciona:

### **Síntoma 1: "No hay datos en la tabla para migrar"**
- **Causa:** No hay favoritos agregados en el DataGrid
- **Solución:** Primero agrega favoritos usando el botón "Agregar"

### **Síntoma 2: Aparece un error diciendo "No se puede acceder a la ruta"**
- **Causa:** Permisos de carpeta o ruta incorrecta
- **Solución:** 
  - Verifica que `Data\favoritos.sqlite` exista
  - Verifica que `Data\inteligencia_climatica.db` sea accesible
  - Asegúrate de tener permisos de escritura en la carpeta `Data`

### **Síntoma 3: La tabla se vacía después de migrar**
- **Causa:** Normal, se está recargando desde SQLite
- **Solución:** Espera 2-3 segundos, deberían reaparecer los datos

---

## 📊 Resumen de cambios técnicos:

| Archivo | Cambio | Detalles |
|---------|--------|----------|
| `DatabaseService.cs` | `MigrarFavoritosASQLiteAsync` | Ahora es async, maneja `FechaAgregado` automáticamente |
| `DatabaseService.cs` | Versión sincrónica | Mantiene compatibilidad pero marcada como `[Obsolete]` |
| `Form1.cs` | `btnMigrar_Click` | Ahora es async, mejor UX y manejo de errores |
| `Form1.Designer.cs` | Posición del botón | Se movió del TopBar al recuadro de Favoritos |

---

## ✅ Test completado exitosamente cuando:

- [ ] Se agregan favoritos correctamente
- [ ] El botón "Migrar Favoritos" aparece en el recuadro rojo
- [ ] Muestra mensaje de éxito con cantidad de registros migrados
- [ ] Los datos aparecen en la tabla SQLite (verificado en DB Browser)
- [ ] Se pueden eliminar favoritos después de migrar
- [ ] No hay excepciones en la consola de depuración

---

¡Listo! Prueba siguiendo estos pasos y hazme saber si encuentras algún problema.
