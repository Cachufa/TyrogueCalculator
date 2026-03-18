#!/bin/bash

# Script de publicación para Tyrogue Evolution Calculator
# Genera ejecutables autocontenidos (no requieren instalar .NET)

PROJECT_PATH="TyrogueCalc/TyrogueCalc.csproj"
OUTPUT_DIR="publish"
RELEASE_DIR="$OUTPUT_DIR/release"

echo "🚀 Iniciando publicación multi-plataforma..."

# Función para publicar y comprimir
publish_platform() {
    RUNTIME=$1
    OS_NAME=$2
    EXTENSION=$3
    ZIP_NAME=$4
    
    echo "----------------------------------------------------"
    echo "📦 Publicando para $OS_NAME ($RUNTIME)..."
    
    PLATFORM_DIR="$OUTPUT_DIR/$RUNTIME"
    
    dotnet publish $PROJECT_PATH \
        -c Release \
        -r $RUNTIME \
        --self-contained true \
        -p:PublishSingleFile=true \
        -p:PublishTrimmed=false \
        -o "$PLATFORM_DIR"
        
    if [ $? -eq 0 ]; then
        echo "✅ Éxito: $PLATFORM_DIR/TyrogueCalc$EXTENSION"
        
        # Comprimir para la release
        echo "🗜️ Comprimiendo para release..."
        
        # Usar rutas absolutas para evitar problemas con cd
        FULL_RELEASE_DIR=$(pwd)/$RELEASE_DIR
        cd "$PLATFORM_DIR"
        zip -q "$FULL_RELEASE_DIR/$ZIP_NAME.zip" "TyrogueCalc$EXTENSION"
        cd - > /dev/null
        
        echo "🎁 Generado: $RELEASE_DIR/$ZIP_NAME.zip"
    else
        echo "❌ Error al publicar para $RUNTIME"
    fi
}

# Limpiar carpeta de publicación
rm -rf $OUTPUT_DIR
mkdir -p "$RELEASE_DIR"

# Windows (x64)
publish_platform "win-x64" "Windows x64" ".exe" "TyrogueCalc_Windows_x64"

# macOS (Intel y Apple Silicon)
publish_platform "osx-x64" "macOS Intel" "" "TyrogueCalc_macOS_Intel"
publish_platform "osx-arm64" "macOS Apple Silicon" "" "TyrogueCalc_macOS_Apple_Silicon"

# Linux (x64)
publish_platform "linux-x64" "Linux x64" "" "TyrogueCalc_Linux_x64"

echo "----------------------------------------------------"
echo "✨ Proceso finalizado."
echo "📂 Los ejecutables individuales están en '$OUTPUT_DIR/'"
echo "🎁 Los archivos listos para RELEASE están en '$RELEASE_DIR/'"
