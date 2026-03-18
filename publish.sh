#!/bin/bash

# Script de publicación para Tyrogue Evolution Calculator
# Genera ejecutables autocontenidos (no requieren instalar .NET)

PROJECT_PATH="TyrogueCalc/TyrogueCalc.csproj"
OUTPUT_DIR="publish"

echo "🚀 Iniciando publicación multi-plataforma..."

# Función para publicar
publish_platform() {
    RUNTIME=$1
    OS_NAME=$2
    EXTENSION=$3
    
    echo "----------------------------------------------------"
    echo "📦 Publicando para $OS_NAME ($RUNTIME)..."
    
    dotnet publish $PROJECT_PATH \
        -c Release \
        -r $RUNTIME \
        --self-contained true \
        -p:PublishSingleFile=true \
        -p:PublishTrimmed=false \
        -o "$OUTPUT_DIR/$RUNTIME"
        
    if [ $? -eq 0 ]; then
        echo "✅ Éxito: $OUTPUT_DIR/$RUNTIME/TyrogueCalc$EXTENSION"
    else
        echo "❌ Error al publicar para $RUNTIME"
    fi
}

# Limpiar carpeta de publicación
rm -rf $OUTPUT_DIR
mkdir -p $OUTPUT_DIR

# Windows (x64)
publish_platform "win-x64" "Windows x64" ".exe"

# macOS (Intel y Apple Silicon)
publish_platform "osx-x64" "macOS Intel" ""
publish_platform "osx-arm64" "macOS Apple Silicon" ""

# Linux (x64)
publish_platform "linux-x64" "Linux x64" ""

echo "----------------------------------------------------"
echo "✨ Proceso finalizado. Los ejecutables están en la carpeta '$OUTPUT_DIR/'"
echo "Nota: En macOS y Linux, es posible que debas dar permisos de ejecución al archivo: chmod +x TyrogueCalc"
